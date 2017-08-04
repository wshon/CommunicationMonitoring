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
            new MamageForm(this, MamageForm.OpenMode.AddFrom).ShowDialog();
        }

        private void removeDeviceRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MamageForm(this, MamageForm.OpenMode.RemoveFrom).ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
