using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SerialLib
{
    public class Serial
    {
        public Label Tb_Stat = new Label();
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
        private SerialPort SerialPortCon = new SerialPort();

        public delegate void DataReceivedDelegate(object sender, SerialDataReceivedEventArgs e);
        public DataReceivedDelegate DataReceived;//= new GreetingDelegate();
        private System.Timers.Timer t = new System.Timers.Timer(500);//实例化Timer类，设置间隔时间为500毫秒；

        public void SerialInit()
        {
            SerialInit(null);
        }
        /// <summary>
        /// 初始化串口
        /// </summary>
        public void SerialInit(SerialPort userSerialPort)
        {
            SerialPortCon.DataReceived += SerialPortCon_DataReceived;

            int count = 0;
            if (userSerialPort != null)
            {
                this.PortName = userSerialPort.PortName;
                this.BaudRate = userSerialPort.BaudRate;
                this.Parity = userSerialPort.Parity;
                this.DataBits = userSerialPort.DataBits;
                this.StopBits = userSerialPort.StopBits;
            }
            else
            {
                this.PortName = "COM0";
                this.BaudRate = 9600;
                this.Parity = System.IO.Ports.Parity.None;
                this.DataBits = 8;
                this.StopBits = System.IO.Ports.StopBits.One;
            }
            Btn_Link.Enabled = true;
            Btn_Link.Text = "连接";
            Btn_Link.Click += Btn_Link_Click;
            //
            //  串口端口号
            //
            cB_SerialPortName.Enabled = true;
            cB_SerialPortName.DropDownStyle = ComboBoxStyle.DropDownList;
            cB_SerialPortName.SelectedItem = this.PortName;
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
            cB_SerialBaudRate.SelectedItem = this.BaudRate;
            cB_SerialBaudRate.SelectedIndexChanged += cB_SerialBaudRate_SelectedIndexChanged;

            //
            //  串口校验位
            //
            cB_SerialParity.Enabled = true;
            cB_SerialParity.DropDownStyle = ComboBoxStyle.DropDownList;
            cB_SerialParity.Items.Clear();
            AddToComBox(cB_SerialParity, typeof(Parity));
            //cB_SerialParity.Items.AddRange(new object[] { Parity.Even, Parity.Mark, Parity.None, Parity.Odd, Parity.Space });
            //cB_SerialParity.Items.AddRange(new object[] { Parity.Even, Parity.Mark, Parity.None, Parity.Odd, Parity.Space });
            foreach (var item in cB_SerialParity.Items)
            {

                if (item.ToString() == this.Parity.ToString())
                {
                    cB_SerialParity.SelectedIndex = count;
                    break;
                }
                count++;
            }
            cB_SerialParity.SelectedIndexChanged += cB_SerialParity_SelectedIndexChanged;

            //
            //  串口数据位
            //
            cB_SerialDataBits.Enabled = true;
            cB_SerialDataBits.DropDownStyle = ComboBoxStyle.DropDownList;
            cB_SerialDataBits.Items.Clear();
            cB_SerialDataBits.Items.AddRange(new object[] { 8, 7});
            cB_SerialDataBits.SelectedItem = this.DataBits;
            cB_SerialDataBits.SelectedIndexChanged += cB_SerialDataBits_SelectedIndexChanged;

            //
            //  串口停止位
            //
            cB_SerialStopBits.Enabled = true;
            cB_SerialStopBits.DropDownStyle = ComboBoxStyle.DropDownList;
            cB_SerialStopBits.Items.Clear();
            AddToComBox(cB_SerialStopBits, typeof(StopBits));
            //cB_SerialStopBits.Items.AddRange(new object[] { StopBits.One, StopBits.OnePointFive, StopBits.Two });
            foreach (var item in cB_SerialStopBits.Items)
            {

                if (item.ToString() == this.StopBits.ToString())
                {
                    cB_SerialStopBits.SelectedIndex = count;
                    break;
                }
                count++;
            }
            cB_SerialStopBits.SelectedItem = this.StopBits;
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
            if (this.PortName == "COM0")
            {
                MessageBox.Show("未选择串口", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((sender as Button).Text == "连接")
            {
                try
                {
                    this.Open();
                    cB_SerialPortName.Enabled = false;
                    cB_SerialBaudRate.Enabled = false;
                    cB_SerialDataBits.Enabled = false;
                    cB_SerialParity.Enabled = false;
                    cB_SerialStopBits.Enabled = false;
                    (sender as Button).Text = "断开";
                }
                catch (Exception err)
                {
                    Debug.WriteLine(err.Message);
                    Tb_Stat.Invoke(new Action(() =>
                    {
                        Tb_Stat.ForeColor = Color.Red;
                        Tb_Stat.Text = "打开失败";
                    }));
                }
            }
            else
            {
                try
                {
                    this.Close();
                    cB_SerialPortName.Enabled = true;
                    cB_SerialBaudRate.Enabled = true;
                    cB_SerialDataBits.Enabled = true;
                    cB_SerialParity.Enabled = true;
                    cB_SerialStopBits.Enabled = true;
                    (sender as Button).Text = "连接";
                }
                catch (Exception err)
                {
                    Debug.WriteLine(err.Message);
                    Tb_Stat.Invoke(new Action(() =>
                    {
                        Tb_Stat.ForeColor = Color.Red;
                        Tb_Stat.Text = "关闭失败";
                    }));
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
            Thread SetProgress = new Thread(() => {
                GetComList(sender);
                //SelectCom(sender);
            });
            SetProgress.Start();
        }
        /// <summary>
        /// 端口号更改操作
        /// </summary>
        private void cB_SerialLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PortName != "")
                this.PortName = GetPortName;
        }
        /// <summary>
        /// 端口号更改操作
        /// </summary>
        private void cB_SerialBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BaudRate = (int)(sender as ComboBox).SelectedItem;
        }
        /// <summary>
        /// 校验位更改操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cB_SerialParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Parity = (Parity)(sender as ComboBox).SelectedIndex;
        }
        /// <summary>
        /// 数据位更改操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cB_SerialDataBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DataBits = (int)(sender as ComboBox).SelectedItem;
        }
        /// <summary>
        /// 停止位更改操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cB_SerialStopBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex == 0) (sender as ComboBox).SelectedIndex = 1;
            if ((sender as ComboBox).SelectedIndex == 3) (sender as ComboBox).SelectedIndex = 2;
            this.StopBits = (StopBits)(sender as ComboBox).SelectedIndex;
        }
        /// <summary>
        /// 获取系统当前的串口
        /// </summary>
        public void GetComList(object sender)
        {
            SerialPort _tempPort;
            String[] Portname = SerialPort.GetPortNames();
            ArrayList userItems = new ArrayList();
            foreach (string str in Portname)
            {
                _tempPort = new SerialPort(str);
                try
                {
                    _tempPort.Open();
                    if (_tempPort.IsOpen)
                    {
                        userItems.Add(str);
                        //(sender as ComboBox).Items.Add(str);
                        _tempPort.Close();
                    }
                }
                catch (Exception err)
                {
                    Debug.WriteLine(err.Message);
                    userItems.Add(str + "(占用)");
                    //(sender as ComboBox).Items.Add(str + "(占用)");
                }
            }
            (sender as ComboBox).Invoke(new Action(() =>
            {
                (sender as ComboBox).Items.Clear();
                (sender as ComboBox).Items.AddRange(userItems.ToArray());
                SelectCom(sender);
            }));
        }
        /// <summary>
        /// 选择默认可连接的串口
        /// </summary>
        /// <returns>是否成功的选择到可连接串口</returns>
        private bool SelectCom(object sender)
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
        private string GetPortName
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



        public void theout(object source, System.Timers.ElapsedEventArgs e)
        {
            if (SerialPortCon.IsOpen)
            {
                t.Interval = 500;
            }
            else
            {
                t.Interval = 2000;
                SerialPortCon.Close();
                try
                {
                    this.Open();
                }
                catch (Exception err)
                {
                    Debug.WriteLine(err.Message);
                    Tb_Stat.Invoke(new Action(() =>
                    {
                        Tb_Stat.ForeColor = Color.Orange;
                        Tb_Stat.Text = "已断开";
                    }));
                }
            }
            //MessageBox.Show("OK!");
        }

        public void Open()
        {
            //try
            //{
            SerialPortCon.Open();
            Tb_Stat.Invoke(new Action(() =>
            {
                Tb_Stat.ForeColor = Color.Green;
                Tb_Stat.Text = "已连接";
            }));

            t.Elapsed += new System.Timers.ElapsedEventHandler(theout);//到达时间的时候执行事件；
            t.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；
            t.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；
            //}
            //catch (Exception err)
            //{
            //    Debug.WriteLine(err.Message);
            //    //this.ForeColor = Color.Red;
            //}
        }

        public void Close()
        {
            t.Enabled = false;
            //try
            //{
            SerialPortCon.Close();
            Tb_Stat.Invoke(new Action(() =>
            {
                Tb_Stat.ForeColor = Color.Red;
                Tb_Stat.Text = "已关闭";
            }));
            //}
            //catch (Exception err)
            //{
            //    Debug.WriteLine(err.Message);
            //}
        }

        public void Write(string text)
        {
            try
            {
                SerialPortCon.Write(text);
            }
            catch (Exception)
            {
                Tb_Stat.Invoke(new Action(() =>
                {
                    Tb_Stat.ForeColor = Color.Red;
                    Tb_Stat.Text = "发送失败";
                }));
            }
        }

        public void Write(char[] buffer, int offset, int count)
        {
            try
            {
                SerialPortCon.Write(buffer, offset, count);
            }
            catch (Exception)
            {
                Tb_Stat.Invoke(new Action(() =>
                {
                    Tb_Stat.ForeColor = Color.Red;
                    Tb_Stat.Text = "发送失败";
                }));
            }
        }

        public bool Write(byte[] buffer, int offset, int count)
        {
            try
            {
                SerialPortCon.Write(buffer, offset, count);
                return true;
            }
            catch (Exception)
            {
                Tb_Stat.Invoke(new Action(() =>
                {
                    Tb_Stat.ForeColor = Color.Red;
                    Tb_Stat.Text = "发送失败";
                }));
                return false;
            }
        }

        public void WriteLine(string text)
        {
            try
            {
                SerialPortCon.WriteLine(text);
            }
            catch (Exception)
            {
                Tb_Stat.Invoke(new Action(() =>
                {
                    Tb_Stat.ForeColor = Color.Red;
                    Tb_Stat.Text = "发送失败";
                }));
            }
        }

        private void SerialPortCon_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            DataReceived(sender, e);
        }

        public string PortName
        {
            set
            {
                SerialPortCon.PortName = value;
            }
            get => SerialPortCon.PortName;
        }

        public int BaudRate
        {
            set
            {
                SerialPortCon.BaudRate = value;
            }
            get => SerialPortCon.BaudRate;
        }

        public int DataBits
        {
            set
            {
                SerialPortCon.DataBits = value;
            }
            get => SerialPortCon.DataBits;
        }

        public object Parity
        {
            set
            {
                SerialPortCon.Parity = (System.IO.Ports.Parity)value;
            }
            get => SerialPortCon.Parity;
        }

        public object StopBits
        {
            set
            {
                SerialPortCon.StopBits = (System.IO.Ports.StopBits)value;
            }
            get => SerialPortCon.StopBits;
        }
    }

}

