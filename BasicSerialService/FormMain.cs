using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InterfaceLink;
using SerialLib;
using System.IO.Ports;
using System.Diagnostics;

namespace BasicSerialService
{
    public partial class FormMain : Form, Interfaces
    {
        #region 全局变量
        private Serial thisSerialPort = new Serial();
        event EventHandler DataReceived;
        #endregion

        #region 主函数
        public FormMain()
        {
            InitializeComponent();
            Init_SerialPort(null);
        }
        public FormMain(string title, SerialPort userSerialPort)
        {
            this.Text = title;
            InitializeComponent();
            Init_SerialPort(userSerialPort);
        }
        //public void FormShow(string title, SerialPort userSerialPort)
        //{
        //    InitializeComponent();
        //    Init_SerialPort(userSerialPort);
        //}
        //public void FormShow()
        //{
        //    FormShow(null, null);
        //}
        #endregion

        #region 窗体事件
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        #endregion

        #region 初始化串口
        private void Init_SerialPort(SerialPort userSerialPort)
        {
            thisSerialPort.cB_SerialPortName = SerialNumberComboBox;
            thisSerialPort.cB_SerialBaudRate = BaudRateComboBox;
            thisSerialPort.cB_SerialParity = ParityComboBox;
            thisSerialPort.cB_SerialDataBits = DataBitsComboBox;
            thisSerialPort.cB_SerialStopBits = StopBitsComboBox;
            thisSerialPort.Btn_Link = addDeviceOKButton;
            thisSerialPort.Tb_Stat = label1;
            thisSerialPort.DataReceived += ThisSerialPort_DataReceived;
            thisSerialPort.SerialInit(userSerialPort);
        }
        #endregion

        #region 串口接收数据
        private void ThisSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            byte[] bufferin;
            int tmp;
            do
            {
                try
                {
                    tmp = (sender as SerialPort).BytesToRead;
                    if (tmp == 0) break;
                    bufferin = new byte[tmp];
                    (sender as SerialPort).Read(bufferin, 0, tmp);
                    //RecvBytes.Value += tmp;
                    //RecvDatas.AddRange(bufferin);
                    //UpdateRecvShow();
                    DataReceived?.Invoke(bufferin, new EventArgs());
                }
                catch (Exception err)
                {
                    Debug.WriteLine(err.Message);
                    break;
                }
            }
            while (true);

            //EventHandler handler = DataReceived;
            //if (handler != null)
            //{
            //    //handler(this, new EventArgs());
            //    handler(sender, e);
            //}
        }
        #endregion

        #region 接口
        void Interfaces.EventTest()
        {
            ThisSerialPort_DataReceived(null, null);
        }

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

        void Interfaces.Write(string text)
        {
            throw new NotImplementedException();
        }

        void Interfaces.Write(char[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        bool Interfaces.Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        void Interfaces.WriteLine(string text)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
