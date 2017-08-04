using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VirtualSerialMonitor
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm frmSerialFrom = new MainForm(textBox1.Text, textBox2.Text);
            frmSerialFrom.MdiParent = this.ParentForm.Owner;
            frmSerialFrom.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "regsvr32";
            p.StartInfo.Verb = "runas";
            p.StartInfo.Arguments = System.Windows.Forms.Application.StartupPath + "\\VSPort.dll";
            p.Start();
            p.WaitForExit();
            p.StartInfo.Arguments = System.Windows.Forms.Application.StartupPath + "\\VSPort64.dll";
            p.Start();
            p.WaitForExit();
            p.Close();
            p.Dispose();
        }
    }
}
