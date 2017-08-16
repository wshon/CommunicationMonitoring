using SerialLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SerialMonitor
{
    public partial class MainForm : Form
    {
        #region 全局变量

        private Serial thisSerialPort = new Serial();
        private BlindInt SentBytes = new BlindInt();
        private BlindInt RecvBytes = new BlindInt();
        private BlindInt FileSendPerss = new BlindInt();
        private BlindString RecvDatasShow = new BlindString();
        private List<byte> RecvDatas = new List<byte>();
        private string NewLineStr = "";
        #endregion

        #region 主函数

        public MainForm()
        {
            InitializeComponent();
            Init_SerialPort(null);
        }
        public MainForm(string title, SerialPort userSerialPort)
        {
            InitializeComponent();
            this.Text = title;
            Init_SerialPort(userSerialPort);
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
            thisSerialPort.Btn_Link = btnLink;
            thisSerialPort.Tb_Stat = label3;
            thisSerialPort.DataReceived += ThisSerialPort_DataReceived;
            thisSerialPort.SerialInit(userSerialPort);
        }

        #endregion

        #region 窗体事件
        /// <summary>
        /// 窗体载入——进行数据绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerialFrom_Load(object sender, EventArgs e)
        {
            tbSendCount.DataBindings.Add("Text", SentBytes, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            tbRecvCount.DataBindings.Add("Text", RecvBytes, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            prebarSendFile.DataBindings.Add("Value", FileSendPerss, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            tbRecvData.DataBindings.Add("Text", RecvDatasShow, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        /// <summary>
        /// 窗体关闭——关闭串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                thisSerialPort.Close();
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
            }
        }
        private void tbRecvData_TextChanged(object sender, EventArgs e)
        {
            tbRecvData.Focus();//获取焦点
            tbRecvData.Select(tbRecvData.TextLength, 0);//光标定位到文本最后
            tbRecvData.ScrollToCaret();//滚动到光标处
        }
        #endregion

        #region 接收数据处理
        /// <summary>
        /// 串口接收数据事件——更新到接收数据内存区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    RecvBytes.Value += tmp;
                    RecvDatas.AddRange(bufferin);
                    UpdateRecvShow();
                    //RecvDatas.Value += " " + System.Text.Encoding.Default.GetString(bufferin);//(bufferin.ToString(  "X2"));
                }
                catch (Exception err)
                {
                    Debug.WriteLine(err.Message);
                    break;
                }
            }
            while (true);
        }
        /// <summary>
        /// 更新窗体的数据绑定
        /// </summary>
        private void UpdateRecvShow()
        {
            Thread SendData = new Thread(() => {
                if (chkShowTypeHex.Checked)
                {
                    RecvDatasShow.Value = Conversion.byteToHexStr(RecvDatas.ToArray(), ' ');
                }
                else
                {

                    RecvDatasShow.Value = System.Text.Encoding.Default.GetString(RecvDatas.ToArray());
                }
                this.Invoke(new Action(() =>
                {
                    WorkToolStripStatusLabel.Text = "";
                }));
            });
            WorkToolStripStatusLabel.Text = "正在运行……";
            SendData.Start();
        }
        #endregion




        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] SendTmp = System.Text.Encoding.Default.GetBytes(textBox2.Text + NewLineStr);
            int SengLenght = SendTmp.Length;
            SentBytes.Value += SengLenght;
            Thread SendData = new Thread(() => {
                thisSerialPort.Write(SendTmp, 0, SengLenght);
                this.Invoke(new Action(() =>
                {
                    btnSend.Enabled = true;
                    btnSend.Text = "发送";
                    WorkToolStripStatusLabel.Text = "";
                }));
            });
            WorkToolStripStatusLabel.Text = "正在运行……";
            btnSend.Enabled = false;
            btnSend.Text = "发送中……";
            SendData.Start();
        }
        
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbSendFile.Text = openFileDialog1.FileName;
                btnSendFile.Enabled = true;
            }
        }

        private void toolStripContainer2_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void ClearToolStripStatusLabel_Click(object sender, EventArgs e)
        {
            SentBytes.Value = 0;
            RecvBytes.Value = 0;
            RecvDatas.Clear();
            UpdateRecvShow();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SentBytes.Value = 0;
            RecvBytes.Value = 0;
            RecvDatas.Clear();
            UpdateRecvShow();
        }


        private void btnLink_Click(object sender, EventArgs e)
        {
            StatToolStripStatusLabel.Text =
                SerialNumberComboBox.Text + "," +
                BaudRateComboBox.Text + "," +
                ParityComboBox.Text + "," +
                DataBitsComboBox.Text + "," +
                StopBitsComboBox.Text;

        }

        private void label3_TextChanged(object sender, EventArgs e)
        {
            ShowToolStripStatusLabel.Text = label3.Text;
            ShowToolStripStatusLabel.ForeColor = label3.ForeColor;
        }

        private void tBRecvCount_TextChanged(object sender, EventArgs e)
        {
            RecvCountToolStripStatusLabel.Text = tbRecvCount.Text;
        }

        private void tBSendCount_TextChanged(object sender, EventArgs e)
        {
            SendCountToolStripStatusLabel.Text = tbSendCount.Text;
        }
        
        private void btnSendFile_Click(object sender, EventArgs e)
        {
            int fRead;
            int SizeBuf;

            byte[] Buff = new byte[Convert.ToInt32(textLen.Text)];
            byte[] BuffPort;
            fRead = Convert.ToInt32(textLen.Text);
            SizeBuf = fRead;
            if (!File.Exists(tbSendFile.Text))
            {
                tbSendFile.Text = "文件未找到";
                btnSendFile.Enabled = false;
                return;
            }
            System.IO.FileStream file = new System.IO.FileStream(tbSendFile.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            prebarSendFile.Maximum = (int)((file.Length / SizeBuf)) + 1;
            FileSendPerss.Value = 0;
            Thread SendFile = new Thread(() => {
                while (fRead == SizeBuf)
                {
                    fRead = file.Read(Buff, 0, SizeBuf);
                    BuffPort = new byte[fRead];
                    Array.Copy(Buff, BuffPort, fRead);
                    if (thisSerialPort.Write(BuffPort, 0, fRead))
                    {
                        SentBytes.Value += fRead;
                        FileSendPerss.Value++;
                    }
                    else
                    {
                        FileSendPerss.Value++;
                        break;
                    }
                }
                this.Invoke(new Action(() =>
                {
                    WorkToolStripStatusLabel.Text = "";
                }));
            });
            WorkToolStripStatusLabel.Text = "正在运行……";
            SendFile.Start();
        }

        private void chkShowTypeHex_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRecvShow();
        }

        private void cmbSendNewLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewLineStr = cmbSendNewLine.Text.Replace("\\r", "\r").Replace("\\n", "\n");
        }
    }

    public class BlindInt : INotifyPropertyChanged
    {
        private int _theValue = 0;

        public int Value
        {
            get { return _theValue; }
            set
            {
                if (value == _theValue)
                    return;
                _theValue = value;
                NotifyPropertyChanged(() => Value);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged<T>(Expression<Func<T>> property)
        {
            if (PropertyChanged == null)
                return;

            var memberExpression = property.Body as MemberExpression;
            if (memberExpression == null)
                return;

            try
            {
                (MainForm.ActiveForm).Invoke(new Action(() =>
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(memberExpression.Member.Name));
                }));
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
            }
        }
    }

    public class BlindString : INotifyPropertyChanged
    {
        private string _theValue = string.Empty;

        public string Value
        {
            get { return _theValue; }
            set
            {
                if (string.IsNullOrEmpty(value) && value == _theValue)
                    return;

                _theValue = value;
                NotifyPropertyChanged(() => Value);
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged<T>(Expression<Func<T>> property)
        {
            if (PropertyChanged == null)
                return;

            var memberExpression = property.Body as MemberExpression;
            if (memberExpression == null)
                return;


            try
            {
                (MainForm.ActiveForm).Invoke(new Action(() =>
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(memberExpression.Member.Name));
                }));
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
            }
        }
    }

    public class MyData : INotifyPropertyChanged
    {
        private string _theValue = string.Empty;

        public string TheValue
        {
            get { return _theValue; }
            set
            {
                if (string.IsNullOrEmpty(value) && value == _theValue)
                    return;

                _theValue = value;
                NotifyPropertyChanged(() => TheValue);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged<T>(Expression<Func<T>> property)
        {
            if (PropertyChanged == null)
                return;

            var memberExpression = property.Body as MemberExpression;
            if (memberExpression == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(memberExpression.Member.Name));
        }
    }
}

