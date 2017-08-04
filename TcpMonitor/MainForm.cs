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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SerialFrom_Load(object sender, EventArgs e)
        {
            SerialPort a=new SerialPort();
            a.Parity = Parity.Even;
            a.DataBits = 8;
        }
    }
}
