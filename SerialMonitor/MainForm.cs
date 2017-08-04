using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace SerialMonitor
{
    public partial class MainForm : Form
    {
        SerialPort thisSerialPort = new SerialPort();
        System.Timers.Timer t = new System.Timers.Timer(500);//实例化Timer类，设置间隔时间为10000毫秒；
        public MainForm(string title,SerialPort userSerialPort)
        {
            InitializeComponent();
            this.Text = title;
            Init_SerialPort(userSerialPort);
        }

        public void theout(object source, System.Timers.ElapsedEventArgs e)
        {
            if (thisSerialPort.IsOpen)
            {
                this.ForeColor = Color.Green;
            }
            else
            {
                thisSerialPort.Close();
                SerialPort_Open(thisSerialPort);
                this.ForeColor = Color.Orange;
            }
            //MessageBox.Show("OK!");
        }
        private void SerialPort_Open(SerialPort userSerialPort)
        {
            try
            {
                thisSerialPort.Open();
                this.ForeColor = Color.Green;

                t.Elapsed += new System.Timers.ElapsedEventHandler(theout);//到达时间的时候执行事件；
                t.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；
                t.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；
            }
            catch
            {
                this.ForeColor = Color.Red;
            }
        }

        private void Init_SerialPort(SerialPort userSerialPort)
        {
            StattoolStripStatusLabel.Text =
                userSerialPort.PortName.ToString() + "," +
                userSerialPort.BaudRate.ToString() + "," +
                userSerialPort.Parity.ToString() + "," +
                userSerialPort.DataBits.ToString() + "," +
                userSerialPort.StopBits.ToString();
            Copy(userSerialPort, thisSerialPort);
            thisSerialPort.DataReceived += ThisSerialPort_DataReceived;
            SerialPort_Open(thisSerialPort);
        }
        private void ThisSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int tmp;
            do
            {
                try
                {
                    tmp = (sender as SerialPort).ReadByte();

                    Invoke((MethodInvoker)delegate ()
                    {
                        textBox1.Text += " "+(tmp.ToString("X2"));
                    });
                }
                catch {
                    break;
                }
            }
            while (true);
        }

        private void SerialFrom_Load(object sender, EventArgs e)
        {
        }

        public void Copy(SerialPort source, SerialPort target)
        {
            target.PortName = source.PortName;
            target.BaudRate = source.BaudRate;
            target.Parity = source.Parity;
            target.DataBits = source.DataBits;
            target.StopBits = source.StopBits;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
            thisSerialPort.Close();
        }
    }
}
