using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace VirtualSerialMonitor
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();

        }
        SerialPort SerialCon1 = new SerialPort();
        SerialPort SerialCon2 = new SerialPort();
        private void button1_Click(object sender, EventArgs e)
        {
            SerialCon1.PortName = textBox1.Text;
            SerialCon2.PortName = textBox2.Text;
            MainForm frmSerialFrom = new MainForm(textBox1.Text + "<---->" + textBox2.Text, SerialCon1, SerialCon2);
            frmSerialFrom.MdiParent = this.ParentForm.Owner;
            frmSerialFrom.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process p = new System.Diagnostics.Process();
            //p.StartInfo.FileName = "RegisterVSPort.exe";
            //p.StartInfo.Verb = "runas";
            //p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //p.Threads.
            ////p.StartInfo.Arguments = "/s \"" + System.Windows.Forms.Application.StartupPath + "\\VSPort.dll\" /i:\"Jinan USR IOT Co., Ltd.#0000K5-ATQURC-ZAR826-7RP5JJ-W3RX79-V7TD62-9AE4C4-AA1397-43BE51-60FDA3-55F088-A46793\"";
            //p.Start();
            //p.WaitForExit();
            //p.Close();
            //p.Dispose();
            try
            {
                System.Diagnostics.Process.Start("RegisterVSPort.exe");
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                //Console.WriteLine("Generic Exception Handler: {0}", Err.ToString());
                MessageBox.Show(err.Message.ToString(), err.Source.ToString());
            }
        }

    }
}
