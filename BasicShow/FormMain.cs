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
using System.Windows.Forms.DataVisualization.Charting;

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
            //((Form)(list[0])).Show();

            //Form tmpFrom = (Form)Activator.CreateInstance(type);
            ((Form)(list[0])).BackColor = Color.White;
            ((Form)(list[0])).Dock = DockStyle.Fill;
            ((Form)(list[0])).FormBorderStyle = FormBorderStyle.None; //隐藏子窗体边框（去除最小花，最大化，关闭等按钮）
            ((Form)(list[0])).TopLevel = false; //指示子窗体非顶级窗体
            //                          /*生成子页面*/
            TabPage tmpPage = new TabPage();
            tmpPage.Controls.Add(((Form)(list[0])));//将子窗体载入panel
            tmpPage.Text = ((Form)(list[0])).Text;
            /*子页面添加至主页*/
            tabControl1.TabPages.Add(tmpPage);
            ((Form)(list[0])).Show();
            //tabControl1.tab
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

        private void tbRecvData_TextChanged(object sender, EventArgs e)
        {
            tbRecvData.Focus();//获取焦点
            tbRecvData.Select(tbRecvData.TextLength, 0);//光标定位到文本最后
            tbRecvData.ScrollToCaret();//滚动到光标处
        }
        /// <summary>
        /// 更新窗体的数据绑定
        /// </summary>
        private void UpdateRecvShow()
        {
            RecvDatasShow.Value = "";
            UpdateRecvShow(RecvDatas.ToArray());
        }


        private void UpdateRecvShow(byte[] buffPort)
        {
            Thread SendData = new Thread(() => {
                if (chkShowTypeHex.Checked)
                {
                    int.TryParse(textBox1.Text, out int leng);
                    RecvDatasShow.Value += Conversion.byteToHexStr(buffPort, ' ', checkBox1.Checked ? leng : 0, checkBox3.Checked);
                }
                else
                {
                    RecvDatasShow.Value += System.Text.Encoding.Default.GetString(buffPort);
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
            UpdateRecvShow(buffPort);
        }

        private void FormMain_DataReceived(object sender, EventArgs e)
        {
            AppendBytes((byte[])sender);
            AppendChart((byte[])sender);
        }

        #endregion



        #region 图表

        private void chart1_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                this.Cursor = Cursors.Cross;
                int i = e.HitTestResult.PointIndex;
                DataPoint dp = e.HitTestResult.Series.Points[i];
                e.Text = string.Format("设备：" + e.HitTestResult.Series.Name + "\nRSSI：{1:F3}" + "dBm\n日期：{0}", DateTime.FromOADate(dp.XValue), dp.YValues[0]);
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            HitTestResult myTestResult = chart1.HitTest(e.X, e.Y);
            if (myTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                this.Cursor = Cursors.Cross;
                int i = myTestResult.PointIndex;
                DataPoint dp = myTestResult.Series.Points[i];

                double doubleXValue = (dp.XValue);
                double doubleYValue = dp.YValues[0];
                //自我实现值的显示            
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }
        RingBuffer buffer = new RingBuffer(240);
        public void AppendChart(byte[] buffPort)
        {
            buffer.WriteBuffer(buffPort);
            while (buffer.GetReserveCount() > 24)
            {
                buffer.ReadBuffer(buffPort, 0, 1);
                buffer.Clear(1);
                if (buffPort[0] == 0xBB)
                {
                    buffer.ReadBuffer(buffPort, 0, 23);
                    buffer.Clear(23);
                    Invoke((MethodInvoker)delegate ()
                    {
                        string series = Conversion.byteToHexStr(new byte[] { buffPort[0], buffPort[1], buffPort[2], buffPort[3] }, ' ');
                        int current = ((buffPort[19] >= 128) ? ((buffPort[19] - 256) / 2 - 75) : (buffPort[19] / 2 - 75));
                        try
                        {
                            chart1.Series[series].Name = series;
                        }
                        catch
                        {
                            Series seriesTmp = new Series();
                            seriesTmp.ChartArea = "ChartArea1";
                            seriesTmp.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                            seriesTmp.Legend = "Legend1";
                            seriesTmp.Name = series;
                            this.chart1.Series.Add(seriesTmp);
                        }
                        //chartShow.Series[series].Points.AddY(current);
                        chart1.Series[series].Points.AddXY(DateTime.Now, current);
                    });
                }
            }
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (int.TryParse(textBox1.Text, out int tmp))
                {
                    textBox1.Enabled = false;
                }
                else
                {
                    checkBox1.Checked = false;
                    MessageBox.Show("长度输入错误");
                    textBox1.Enabled = true;
                    textBox1.Focus();
                }
            }
            else
            {
                textBox1.Enabled = true;
            }
            UpdateRecvShow();
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
