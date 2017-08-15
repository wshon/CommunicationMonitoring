using SerialLib;
using System;
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

        Serial thisSerialPort = new Serial();

        private BlindInt SentBytes, RecvBytes;
        private BlindInt FileSendPerss;

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

        private void ThisSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //byte[] bufferin = new byte[(sender as SerialPort).ReadBufferSize];
            int tmp;
            do
            {
                try
                {
                    tmp = (sender as SerialPort).ReadByte();
                    RecvBytes.Value++;
                    Invoke((MethodInvoker)delegate ()
                    {
                        textBox1.Text += " "+(tmp.ToString("X2"));
                    });
                }
                catch (Exception err)
                {
                    Debug.WriteLine(err.Message);
                    break;
                }
            }
            while (true);
        }
        
        private void SerialFrom_Load(object sender, EventArgs e)
        {
            SentBytes = new BlindInt();
            RecvBytes = new BlindInt();
            FileSendPerss = new BlindInt();

            tBSendCount.DataBindings.Add("Text", SentBytes, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            tBRecvCount.DataBindings.Add("Text", RecvBytes, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            prebarSendFile.DataBindings.Add("Value", FileSendPerss, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        //public void Copy(SerialPort source, SerialPort target)
        //{
        //    target.PortName = source.PortName;
        //    target.BaudRate = source.BaudRate;
        //    target.Parity = source.Parity;
        //    target.DataBits = source.DataBits;
        //    target.StopBits = source.StopBits;
        //}

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.AppendText(Label);     // 追加文本，并且使得光标定位到插入地方。
            //textBox1.ScrollToCaret();

            textBox1.Focus();//获取焦点
            textBox1.Select(textBox1.TextLength, 0);//光标定位到文本最后
            textBox1.ScrollToCaret();//滚动到光标处
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SentBytes.Value += textBox2.Text.Length;
            thisSerialPort.Write(textBox2.Text);
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SentBytes.Value = 0;
            RecvBytes.Value = 0;
        }

        private void tBRecvCount_TextChanged(object sender, EventArgs e)
        {
            RecvCountToolStripStatusLabel.Text = tBRecvCount.Text;
        }

        private void tBSendCount_TextChanged(object sender, EventArgs e)
        {
            SendCountToolStripStatusLabel.Text = tBSendCount.Text;
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            StatToolStripStatusLabel.Text =
                SerialNumberComboBox.Text+"," +
                BaudRateComboBox.Text + "," +
                ParityComboBox.Text + "," +
                DataBitsComboBox.Text + "," +
                StopBitsComboBox.Text;

        }

        private void label3_TextChanged(object sender, EventArgs e)
        {
            ShowToolStripStatusLabel.Text = label3.Text;
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
            });
            SendFile.Start();
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

