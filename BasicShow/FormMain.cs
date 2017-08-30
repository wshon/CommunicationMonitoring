using Conver;
using InterfaceLink;
using Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BasicShow
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        List<Interfaces> list = new List<Interfaces>();
        private BlindInt SendBytes = new BlindInt();
        private BlindInt RecvBytes = new BlindInt();
        private BlindInt FileSendPrs = new BlindInt();
        private BlindString SendDatasShow = new BlindString();
        private BlindString RecvDatasShow = new BlindString();

        private List<byte> RecvDatas = new List<byte>();
        private string NewLineStr = "";
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            tbSendCount.DataBindings.Add("Text", SendBytes, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            tbRecvCount.DataBindings.Add("Text", RecvBytes, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            prsSendFile.DataBindings.Add("Value", FileSendPrs, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            tbRecvData.DataBindings.Add("Text", RecvDatasShow, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            tbSendData.DataBindings.Add("Text", SendDatasShow, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //string dir = @"c:\Libs\";
            //string assemblyName = "InterfaceLink";
            //for (int i = 0; i < 3; i++)
            //{
            //Assembly assembly = Assembly.LoadFile(dir + assemblyName + ".dll");
            //Type type = assembly.GetType(assemblyName + ".Interfaces");
            //Interfaces instance = System.Activator.CreateInstance(type) as Interfaces;
            list = new PageMamage().ExternInterface_Load("FormMain");
            //Interfaces instance = PageMamage.LoadInterface("InterfaceLink", "Interfaces");
            //    list.Add(instance);
            //}
            list[0].DataReceived += FormMain_DataReceived;
            list[0].EventTest();
            ((Form)(list[0])).Show();
        }

        #region 数据统计
        private void tbRecvCount_TextChanged(object sender, EventArgs e)
        {
            RecvCountToolStripStatusLabel.Text = tbRecvCount.Text;
        }

        private void tbSendCount_TextChanged(object sender, EventArgs e)
        {
            SendCountToolStripStatusLabel.Text = tbSendCount.Text;
        }

        private void ClearToolStripStatusLabel_Click(object sender, EventArgs e)
        {
            ClearCountBytes();
        }
        private void ClearCountBytes()
        {
            SendBytes.Value = 0;
            RecvBytes.Value = 0;
        }
        #endregion

        #region 接收显示数据
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
            if (!chkShowPause.Checked)
            {
                this.Invoke(new Action(() =>
                {
                    WorkToolStripStatusLabel.Text = "正在更新数据窗口……";
                }));
                SendData.Start();
            }
        }

        private void chkShowTypeHex_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRecvShow();
        }

        private void chkShowPause_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRecvShow();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            RecvDatas.Clear();
            RecvDatasShow.Value = "";
            ClearCountBytes();
        }
        #endregion

        #region 接收数据
        public void AppendBytes(byte[] buffPort)
        {
            RecvBytes.Value += buffPort.Length;
            RecvDatas.AddRange(buffPort);
            UpdateRecvShow();
        }

        private void FormMain_DataReceived(object sender, EventArgs e)
        {
            AppendBytes((byte[])sender);
        }
        #endregion

        #region 发送数据
        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] SendTmp = System.Text.Encoding.Default.GetBytes(tbSendData.Text + NewLineStr);
            int SengLenght = SendTmp.Length;
            SendBytes.Value += SengLenght;
            Thread SendData = new Thread(() => {
                list[0].Write(SendTmp, 0, SengLenght);
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
        #endregion

        #region 发送文件
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
            prsSendFile.Maximum = (int)((file.Length / SizeBuf)) + 1;
            FileSendPrs.Value = 0;
            Thread SendFile = new Thread(() => {
                while (fRead == SizeBuf)
                {
                    fRead = file.Read(Buff, 0, SizeBuf);
                    BuffPort = new byte[fRead];
                    Array.Copy(Buff, BuffPort, fRead);
                    if (list[0].Write(BuffPort, 0, fRead))
                    {
                        SendBytes.Value += fRead;
                        FileSendPrs.Value++;
                    }
                    else
                    {
                        FileSendPrs.Value++;
                        break;
                    }
                }
                this.Invoke(new Action(() =>
                {
                    WorkToolStripStatusLabel.Text = "";
                }));
            });
            WorkToolStripStatusLabel.Text = "正在发送文件……";
            SendFile.Start();
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
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            var path = Process.GetCurrentProcess().MainModule.FileName + " s";
            DirectoryInfo TheFolder = new DirectoryInfo(".\\");
            foreach (FileInfo file in TheFolder.GetFiles())
            {
                if (file.Extension == ".dll")
                {
                    try
                    {
                        Debug.WriteLine("Find dll:" + file.Name);
                        Type type = PageMamage.LoadFromType(".\\" + file.Name, "Mamage");
                        Object obj = Activator.CreateInstance(type);
                        MethodInfo mi = type.GetMethod("install");
                        mi.Invoke(obj, null);
                    }
                    catch { }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var path = Process.GetCurrentProcess().MainModule.FileName + " s";
            DirectoryInfo TheFolder = new DirectoryInfo(".\\");
            foreach (FileInfo file in TheFolder.GetFiles())
            {
                if (file.Extension == ".dll")
                {
                    try
                    {
                        Debug.WriteLine("Find dll:" + file.Name);
                        Type type = PageMamage.LoadFromType(".\\" + file.Name, "Mamage");
                        Object obj = Activator.CreateInstance(type);
                        MethodInfo mi = type.GetMethod("uninstall");
                        mi.Invoke(obj, null);
                    }
                    catch { }
                }
            }
        }
    }

    #region 数据绑定
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
                (FormMain.ActiveForm).Invoke(new Action(() =>
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
                (FormMain.ActiveForm).Invoke(new Action(() =>
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
    #endregion

}
