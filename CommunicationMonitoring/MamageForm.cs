using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace CommunicationMonitoring
{
    public partial class MamageForm : Form
    {
        public enum OpenMode
        {
            AddFrom,
            RemoveFrom
        }

        public MamageForm(Form userMdiParent, OpenMode userOpenMode)
        {
            InitializeComponent();
            this.Owner = userMdiParent; //Transmit "MDIParent" from "owner" to "children".
            switch (userOpenMode)
            {
                case OpenMode.AddFrom:
                    mamageTabControl.SelectedTab = mamageTabControl.TabPages[addDeviceTabPage.Name];
                    AddDeviceTabPage_Load();
                break;
                case OpenMode.RemoveFrom:
                    mamageTabControl.SelectedTab = mamageTabControl.TabPages[removeDeviceTabPage.Name];
                    RemoveDeviceTabPage_Load();
                    break;
                default:
                    break;
            } //Windows open mode.
        }


        #region Windows move with mouse.
        private void SetControlsActive(Control fatherControl)
        {
            Control.ControlCollection sonControls = fatherControl.Controls;
            //遍历所有控件
            foreach (Control control in sonControls)
            {
                if (control.Controls.Count != 0)
                {
                    control.MouseDown += MamageForm_MouseDown;
                    control.MouseMove += MamageForm_MouseMove;
                    control.MouseUp += MamageForm_MouseUp;
                    SetControlsActive(control);
                }
                else if (control is Label)
                {
                    control.MouseDown += MamageForm_MouseDown;
                    control.MouseMove += MamageForm_MouseMove;
                    control.MouseUp += MamageForm_MouseUp;
                }
            }
        }
        
        private Point mPoint = new Point();
        private void MamageForm_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint.X = Location.X - MousePosition.X;
            mPoint.Y = Location.Y - MousePosition.Y;
        }
        private void MamageForm_MouseUp(object sender, MouseEventArgs e)
        {
            mPoint.X = 0;
            mPoint.Y = 0;

        }
        private void MamageForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (mPoint.X != 0 && mPoint.Y != 0)
                {
                    Point mPosittion = MousePosition;
                    mPosittion.Offset(mPoint.X, mPoint.Y);
                    Location = mPosittion;
                }
            }
        }
        #endregion

        #region Windows close with key.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MamageForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                exitButton.PerformClick();
        }
        #endregion

        private void MamageForm_Load(object sender, EventArgs e)
        {
            SetControlsActive(this);
        }
        
        #region MamageTabControl
        private void MamageTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mamageTabControl.SelectedTab.Name == addDeviceTabPage.Name)
            {
                AddDeviceTabPage_Load();
            }
            else if (mamageTabControl.SelectedTab.Name == removeDeviceTabPage.Name)
            {
                RemoveDeviceTabPage_Load();
            }
        }

        #endregion

        #region AddDeviceTabPage
        private void AddDeviceTabPage_Load()
        {
            tabControl.TabPages.Clear();
            new PageMamage().ExternMode_Load(tabControl, "StartForm");
            SetControlsActive(addDeviceTabPage);
        }
        #endregion

        #region RemoveDeviceTabPage
        private void RemoveDeviceTabPage_Load()
        {
            listView1.Items.Clear();
            foreach (Form item in this.Owner.MdiChildren)
            {
                listView1.Items.Add(item.Text);
                    listView1.Items[listView1.Items.Count - 1].ForeColor
                        = item.ForeColor;
            }
            SetControlsActive(removeDeviceTabPage);
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Selected)
                {
                    this.Owner.MdiChildren[item.Index].Close();
                    item.Remove();
                }
            }
        }
        #endregion
    }
}
