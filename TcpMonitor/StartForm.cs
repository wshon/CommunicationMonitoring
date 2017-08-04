using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SocketMonitor
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            if (comboBox4.Items.Count == 0)
            {
                AddToComBox(comboBox4, typeof(StopBits));
                comboBox4.SelectedIndex = 1;
            }
            if (comboBox5.Items.Count == 0)
            {
                AddToComBox(comboBox5, typeof(Parity));
                comboBox5.SelectedIndex = 0;
            }
        }

        private void AddToComBox(ComboBox thisComboBox, Type thisEnum)
        {
            var ss = Enum.GetNames(thisEnum);
            foreach (var t in ss)
            {
                thisComboBox.Items.Add(t);
            }
        }

        private void addDeviceOKButton_Click(object sender, EventArgs e)
        {
            MainForm frmSerialFrom = new MainForm();
            frmSerialFrom.MdiParent = this.ParentForm.Owner;
            frmSerialFrom.Show();
        }

        private void addDeviceCancelButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
