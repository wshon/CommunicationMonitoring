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
        private BlindInt SentBytes = new BlindInt();
        private BlindInt RecvBytes = new BlindInt();
        private BlindInt FileSendPerss = new BlindInt();
        private BlindString RecvDatasShow = new BlindString();
        private List<byte> RecvDatas = new List<byte>();
        private string NewLineStr = "";
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            tbSendCount.DataBindings.Add("Text", SentBytes, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            tbRecvCount.DataBindings.Add("Text", RecvBytes, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            prebarSendFile.DataBindings.Add("Value", FileSendPerss, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            tbRecvData.DataBindings.Add("Text", RecvDatasShow, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
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
                    if (list[0].Write(BuffPort, 0, fRead))
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
            WorkToolStripStatusLabel.Text = "正在发送文件……";
            SendFile.Start();
        }

        private void tbRecvCount_TextChanged(object sender, EventArgs e)
        {
            RecvCountToolStripStatusLabel.Text = tbRecvCount.Text;
        }

        private void tbSendCount_TextChanged(object sender, EventArgs e)
        {
            SendCountToolStripStatusLabel.Text = tbSendCount.Text;
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
            WorkToolStripStatusLabel.Text = "正在更新数据窗口……";
            SendData.Start();
        }

        public void AppendBytes(byte[] buffPort)
        {
            RecvDatas.AddRange(buffPort);
            UpdateRecvShow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Interfaces> list = new List<Interfaces>();
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
            list.ToArray()[0].DataReceived += FormMain_DataReceived;
            list.ToArray()[0].EventTest();
        }

        private void FormMain_DataReceived(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
