using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerialLib
{
    public class Serial
    {
        public Button Btn_Link = new Button();
        /// <summary>
        /// 选择端口号使用（必需）
        /// </summary>
        public ComboBox cB_SerialPortName = new ComboBox();
        /// <summary>
        /// 通讯数率使用（默认：9600）
        /// </summary>
        public ComboBox cB_SerialBaudRate = new ComboBox();
        /// <summary>
        ///校验位使用（默认：None）
        /// </summary>
        public ComboBox cB_SerialParity = new ComboBox();
        /// <summary>
        /// 数据位使用（默认：8）
        /// </summary>
        public ComboBox cB_SerialDataBits = new ComboBox();
        /// <summary>
        /// 停止位使用（默认：One）
        /// </summary>
        public ComboBox cB_SerialStopBits = new ComboBox();
        /// <summary>
        /// 串口控制流
        /// </summary>
        public ComboBox cB_SerialFlowCtrl = new ComboBox();
        /// <summary>
        /// 串口实例
        /// </summary>
        public SerialPort SerialPortCon = new SerialPort();

        public delegate void DataReceivedDelegate(byte[] buffer);
        public DataReceivedDelegate DataReceived;//= new GreetingDelegate();

        /// <summary>
        /// 初始化串口
        /// </summary>
        public void SerialInit()
        {
            SerialPortCon.PortName = "COM0";
            SerialPortCon.BaudRate = 9600;
            SerialPortCon.Parity = Parity.None;
            SerialPortCon.DataBits = 8;
            SerialPortCon.StopBits = StopBits.One;
            //SerialPortCon.DataReceived += SerialPortCon_DataReceived;
            Btn_Link.Enabled = true;
            Btn_Link.Text = "连接";
            Btn_Link.Click += Btn_Link_Click;
            //
            //  串口端口号
            //
            cB_SerialPortName.Enabled = true;
            cB_SerialPortName.DropDownStyle = ComboBoxStyle.DropDownList;
            cB_SerialPortName.DropDown += new EventHandler(cB_SerialLine_DropDown);
            //cB_SerialPortName.SelectedIndexChanged += new EventHandler(cB_SerialLine_SelectedIndexChanged);
            cB_SerialPortName.SelectedIndexChanged += cB_SerialLine_SelectedIndexChanged;

            cB_SerialLine_DropDown(cB_SerialPortName, new EventArgs());

            //
            //  串口波特率
            //
            cB_SerialBaudRate.Enabled = true;
            cB_SerialBaudRate.DropDownStyle = ComboBoxStyle.DropDown;
            cB_SerialBaudRate.Items.Clear();
            cB_SerialBaudRate.Items.AddRange(new object[] { 300, 600, 1200, 2400, 4800, 9600, 19200, 38400, 43000, 57600, 76800, 115200, 128000, 230400, 256000, 460800, 512000, 921600, 1024000, 1382400 });
            cB_SerialBaudRate.SelectedIndex = 5;
            cB_SerialBaudRate.SelectedIndexChanged += cB_SerialBaudRate_SelectedIndexChanged;

            //
            //  串口校验位
            //
            cB_SerialParity.Enabled = true;
            cB_SerialParity.DropDownStyle = ComboBoxStyle.DropDownList;
            cB_SerialParity.Items.Clear();
            AddToComBox(cB_SerialParity, typeof(Parity));
            //cB_SerialParity.Items.AddRange(new object[] { Parity.Even, Parity.Mark, Parity.None, Parity.Odd, Parity.Space });
            cB_SerialParity.SelectedIndex = 0;
            cB_SerialParity.SelectedIndexChanged += cB_SerialParity_SelectedIndexChanged;

            //
            //  串口数据位
            //
            cB_SerialDataBits.Enabled = true;
            cB_SerialDataBits.DropDownStyle = ComboBoxStyle.DropDownList;
            cB_SerialDataBits.Items.Clear();
            cB_SerialDataBits.Items.AddRange(new object[] { 8, 7, 6, 5 });
            cB_SerialDataBits.SelectedIndex = 0;
            cB_SerialDataBits.SelectedIndexChanged += cB_SerialDataBits_SelectedIndexChanged;

            //
            //  串口停止位
            //
            cB_SerialStopBits.Enabled = true;
            cB_SerialStopBits.DropDownStyle = ComboBoxStyle.DropDownList;
            cB_SerialStopBits.Items.Clear();
            AddToComBox(cB_SerialStopBits, typeof(StopBits));
            //cB_SerialStopBits.Items.AddRange(new object[] { StopBits.One, StopBits.OnePointFive, StopBits.Two });
            cB_SerialStopBits.SelectedIndex = 1;
            cB_SerialStopBits.SelectedIndexChanged += cB_SerialStopBits_SelectedIndexChanged;

            //
            //  串口控制流
            //
            cB_SerialFlowCtrl.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AddToComBox(ComboBox thisComboBox, Type thisEnum)
        {
            var ss = Enum.GetNames(thisEnum);
            foreach (var t in ss)
            {
                thisComboBox.Items.Add(t);
            }
        }

        /*
        private void SerialPortCon_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int i = 0;
            byte tmp = 0;
            int pre_start = 0;
            bool pre_stop = false;
            int frameNumber = 0;
            int frameClass = 0;
            int frameLenght = 0;
            int frameValue = 0;
            byte[] bufferin = new byte[(sender as SerialPort).ReadBufferSize];
            byte[] bufferout = new byte[i]; 
            //int zero = 0;
            do
            {
                //55 AA 18 06 11    帧头
                //60 12 52 0B       IP地址
                //05                线偏、相偏
                //00 01             组地址
                //C3                无线模块加未知字节
                //00                电压高位
                //00                电流低位
                //00                电流高位
                //9B                最大电流低位
                //00                最大电流高位
                //00                状态字
                //00                状态字
                //16                故障信息位
                //55                电压低位
                //CD                累加和
                //16                帧尾
                //55 AA 16 07 58 09 00 11 D2 11 00 00 D0 07 00 00 00 00 8C 5C 31 16
                try { tmp = (byte)(sender as SerialPort).ReadByte(); }
                catch { break; }
                switch (pre_start)
                {
                    case 0: //解析报文头55
                        if (tmp == 0x55)
                        {
                            pre_start = 1;
                            bufferin[0] = tmp;
                        }
                        else
                            pre_start = 0;
                        break;
                    case 1: //解析报文头AA
                        if (tmp == 0xAA)
                        {
                            pre_start = 2;
                            bufferin[1] = tmp;
                        }
                        else if (tmp == 0x55)
                        {
                            pre_start = 1;
                            bufferin[0] = tmp;
                        }
                        else
                            pre_start = 0;
                        break;
                    case 2: //帧命令类型
                        frameClass = tmp;
                        bufferin[2] = tmp;
                        pre_start = 3;
                        break;
                    case 3: //固定帧D2
                        frameNumber = tmp;
                        bufferin[3] = tmp;
                        pre_start = 4;
                        break;
                    case 4: //帧长度
                        frameLenght = tmp;
                        bufferin[4] = tmp;
                        pre_start = 5;
                        i = 5;
                        break;
                    case 5: //帧命令数据
                        if (i == frameLenght + 5)
                            pre_start = 6;
                        bufferin[i++] = tmp;
                        break;
                    case 6:
                        bufferin[i++] = tmp;
                        bufferin[i] = 0x16;
                        bufferout = new byte[i];
                        while (i-- > 0)
                        {
                            bufferout[i] = bufferin[i];
                        }
                        pre_stop = true;
                        break;
                }
                
            }
            while (!pre_stop);
            DataReceived(bufferout);
            //throw new NotImplementedException();
        }
        */

        private void Btn_Link_Click(object sender, EventArgs e)
        {
            if (SerialPortCon.PortName == "COM0")
            {
                MessageBox.Show("未选择串口", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((sender as Button).Text == "连接")
            {
                try
                {
                    SerialPortCon.Open();
                    cB_SerialPortName.Enabled = false;
                    cB_SerialBaudRate.Enabled = false;
                    cB_SerialDataBits.Enabled = false;
                    cB_SerialParity.Enabled = false;
                    cB_SerialStopBits.Enabled = false;
                    (sender as Button).Text = "断开";
                }
                catch
                {
                    MessageBox.Show(SerialPortCon.PortName + " 打开失败", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    SerialPortCon.Close();
                    cB_SerialPortName.Enabled = true;
                    cB_SerialBaudRate.Enabled = true;
                    cB_SerialDataBits.Enabled = true;
                    cB_SerialParity.Enabled = true;
                    cB_SerialStopBits.Enabled = true;
                    (sender as Button).Text = "连接";
                }
                catch
                {
                    MessageBox.Show(SerialPortCon.PortName + " 关闭失败", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //this.Update();
        }
        /// <summary>
        /// 端口号刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cB_SerialLine_DropDown(object sender, EventArgs e)
        {
            GetComList(sender);
            SelectCom(sender);
        }
        /// <summary>
        /// 端口号更改操作
        /// </summary>
        private void cB_SerialLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PortName != "")
                SerialPortCon.PortName = PortName;
        }
        /// <summary>
        /// 端口号更改操作
        /// </summary>
        private void cB_SerialBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialPortCon.BaudRate = (int)(sender as ComboBox).SelectedItem;
        }
        /// <summary>
        /// 校验位更改操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cB_SerialParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialPortCon.Parity = (Parity)(sender as ComboBox).SelectedIndex;
        }
        /// <summary>
        /// 数据位更改操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cB_SerialDataBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialPortCon.DataBits = (int)(sender as ComboBox).SelectedItem;
        }
        /// <summary>
        /// 停止位更改操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cB_SerialStopBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex == 0) (sender as ComboBox).SelectedIndex = 1;
            SerialPortCon.StopBits = (StopBits)(sender as ComboBox).SelectedIndex;
        }
        /// <summary>
        /// 获取系统当前的串口
        /// </summary>
        public void GetComList(object sender)
        {
            SerialPort _tempPort;
            String[] Portname = SerialPort.GetPortNames();
            (sender as ComboBox).Items.Clear();
            foreach (string str in Portname)
            {
                _tempPort = new SerialPort(str);
                try
                {
                    _tempPort.Open();
                    if (_tempPort.IsOpen)
                    {
                        (sender as ComboBox).Items.Add(str);
                        _tempPort.Close();
                    }
                }
                catch
                {
                    (sender as ComboBox).Items.Add(str + "(占用)");
                }
            }
        }
        /// <summary>
        /// 选择默认可连接的串口
        /// </summary>
        /// <returns>是否成功的选择到可连接串口</returns>
        public bool SelectCom(object sender)
        {
            foreach (string str in (sender as ComboBox).Items)
            {
                if (str.IndexOf("(") == -1)
                {
                    int i = (sender as ComboBox).Items.IndexOf(str);
                    (sender as ComboBox).SelectedIndex = i;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 从下拉菜单选中项中获取端口号
        /// </summary>
        public string PortName
        {
            get
            {
                if (cB_SerialPortName.Text.IndexOf("(") == -1)
                {
                    return cB_SerialPortName.Text;
                }
                else
                    return cB_SerialPortName.Text.Remove(cB_SerialPortName.Text.Length - 4, 4); 
            } 
        }



    }

}

