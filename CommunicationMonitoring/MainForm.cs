using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace CommunicationMonitoring
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addDeviceAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MamageFormOpen(MamageForm.OpenMode.AddFrom);
        }

        private void removeDeviceRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MamageFormOpen(MamageForm.OpenMode.RemoveFrom);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MamageFormOpen(MamageForm.OpenMode userOpenMode)
        {
            foreach (Form childFrm in Application.OpenForms)
            {
                //用子窗体的Name进行判断，如果已经存在则将他激活
                if (childFrm.Name == "MamageForm")
                {
                    if (childFrm.WindowState == FormWindowState.Minimized)
                        childFrm.WindowState = FormWindowState.Normal;
                    //childFrm = new MamageForm(this, MamageForm.OpenMode.AddFrom);
                    childFrm.Activate();
                    return;
                }
            }
            new MamageForm(this, MamageForm.OpenMode.AddFrom).Show();
        }

    }
}
