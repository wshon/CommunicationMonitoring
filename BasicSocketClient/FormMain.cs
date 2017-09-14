using InterfaceLink;
using SocketClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace BasicSocketClient
{
    public partial class FormMain : Form, Interfaces
    {
        public FormMain()
        {
            InitializeComponent();
        }

        #region 接口
        event EventHandler Interfaces.DataReceived
        {
            add
            {
                DataReceived += value;
                //throw new NotImplementedException();
            }

            remove
            {
                DataReceived -= value;
                //throw new NotImplementedException();
            }
        }

        void Interfaces.EventTest()
        {
            //throw new NotImplementedException();
        }

        bool Interfaces.Write(string text)
        {
            throw new NotImplementedException();
        }

        bool Interfaces.Write(char[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        bool Interfaces.Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        bool Interfaces.WriteLine(string text)
        {
            throw new NotImplementedException();
        }
        #endregion

        IPAddress ip;
        Int32 port;
        SocketHelper _SocketClient;
        //private EventHandler DataReceived;
        event EventHandler DataReceived;

        private void addDeviceOKButton_Click(object sender, EventArgs e)
        {
            if (addDeviceOKButton.Text == "断开连接")
            {
                if (_SocketClient.SocketUnlink())
                {
                    label1.Text = "断开连接成功";
                    addDeviceOKButton.Text = "建立连接";
                }
                else
                {
                    label1.Text = "断开连接失败";
                }
            }
            else
            {
                if (!IPAddress.TryParse(SocketIPComboBox.Text, out ip))
                {
                    errorProvider1.SetError(SocketIPComboBox, "IP地址类型错误");
                    return;
                }
                else
                {
                    errorProvider1.Clear();
                }
                if (!Int32.TryParse(SocketPortComboBox.Text, out port))
                {
                    errorProvider1.SetError(SocketPortComboBox, "端口输入错误");
                    return;
                }
                else
                {
                    errorProvider1.Clear();
                }
                _SocketClient = new SocketHelper(ip, port);
                if (_SocketClient.Socketlink())
                {
                    label1.Text = "连接成功";
                    _SocketClient.ReceiveMessage();
                    addDeviceOKButton.Text = "断开连接";
                    _SocketClient.DataReceived += ThisSerialPort_DataReceived;
                }
                else
                {
                    label1.Text = "连接失败";
                }
            }
        }
        private void ThisSerialPort_DataReceived(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                DataReceived?.Invoke(((byte[])sender), new EventArgs());
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] bufferin = { 0x01, 0x02, 0x03 };
            DataReceived?.Invoke(bufferin, new EventArgs()); 
        }
    }
}
