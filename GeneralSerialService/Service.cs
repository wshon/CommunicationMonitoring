using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using InterfaceLink;
using SerialLib;
using System.IO.Ports;
using System.IO;

namespace GeneralSerialService
{
    partial class Service : ServiceBase, Interfaces
    {
        #region 全局变量
        private Serial thisSerialPort = new Serial();
        event EventHandler DataReceived;
        #endregion

        public Service()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: 在此处添加代码以启动服务。
            System.IO.File.AppendAllText("D:\\log.txt", "服务已启动……" + DateTime.Now.ToString());
        }

        protected override void OnStop()
        {
            // TODO: 在此处添加代码以执行停止服务所需的关闭操作。
            System.IO.File.AppendAllText("D:\\log.txt", "服务已停止……" + DateTime.Now.ToString());
        }


        #region 初始化串口
        //private void Init_SerialPort(SerialPort userSerialPort)
        //{
        //    thisSerialPort.cB_SerialPortName = SerialNumberComboBox;
        //    thisSerialPort.cB_SerialBaudRate = BaudRateComboBox;
        //    thisSerialPort.cB_SerialParity = ParityComboBox;
        //    thisSerialPort.cB_SerialDataBits = DataBitsComboBox;
        //    thisSerialPort.cB_SerialStopBits = StopBitsComboBox;
        //    thisSerialPort.Btn_Link = addDeviceOKButton;
        //    thisSerialPort.Tb_Stat = label1;
        //    thisSerialPort.DataReceived += ThisSerialPort_DataReceived;
        //    thisSerialPort.SerialInit(userSerialPort);
        //}
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
            ThisSerialPort_DataReceived(null, null);
        }

        bool Interfaces.Write(string text)
        {
            return thisSerialPort.Write(text);
        }

        bool Interfaces.Write(char[] buffer, int offset, int count)
        {
            return thisSerialPort.Write(buffer, offset, count);
        }

        bool Interfaces.Write(byte[] buffer, int offset, int count)
        {
            return thisSerialPort.Write(buffer, offset, count);
        }

        bool Interfaces.WriteLine(string text)
        {
            return thisSerialPort.WriteLine(text);
        }
        #endregion
    }
}
