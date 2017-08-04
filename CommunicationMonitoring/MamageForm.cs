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
            ExternMode_Load();
            SetControlsActive(addDeviceTabPage);
        }
        private void ExternMode_Load()
        {
            /*加载model*/
            //C#遍历models文件夹中的所有文件 
            DirectoryInfo TheFolder = new DirectoryInfo(".\\");
            if (TheFolder.Exists == false) TheFolder.Create();
            int modelLoadPass = 0, modelLoadFail = 0;
            foreach (FileInfo file in TheFolder.GetFiles())
            {
                if (file.Extension == ".dll")
                    if (LoadPage(".\\" + file.Name, tabControl))
                        modelLoadPass++;
                    else
                        modelLoadFail++;
            }
            //modelcount.Text = "Model:" + modelLoadPass.ToString() + " Fail:" + modelLoadFail.ToString();

        }
        private bool LoadPage(String assName, TabControl tabControltmp)
        {
            try
            {
                Assembly ass = Assembly.LoadFrom(assName);
#if DEBUG
                Console.WriteLine(ass.FullName);
#endif
                /*载入model*/
                Type type = ass.GetType(ass.GetName().Name + ".StartForm");
                /*载入ui*/
                Form tmpFrom = (Form)Activator.CreateInstance(type);
                tmpFrom.BackColor = Color.White;
                tmpFrom.Dock = DockStyle.Fill;
                tmpFrom.FormBorderStyle = FormBorderStyle.None; //隐藏子窗体边框（去除最小花，最大化，关闭等按钮）
                tmpFrom.TopLevel = false; //指示子窗体非顶级窗体
                /*生成子页面*/
                TabPage tmpPage = new TabPage();
                tmpPage.Controls.Add(tmpFrom);//将子窗体载入panel
                tmpPage.Text = tmpFrom.Text;
                /*子页面添加至主页*/
                tabControltmp.TabPages.Add(tmpPage);
                tmpFrom.Show();
                return true;
            }
            catch
            {
                return false;
            }

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
