namespace SerialMonitor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tbRecvData = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chkShowTypeHex = new System.Windows.Forms.CheckBox();
            this.btnLink = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.SerialNumberComboBox = new System.Windows.Forms.ComboBox();
            this.lbDataBits = new System.Windows.Forms.Label();
            this.tbRecvCount = new System.Windows.Forms.TextBox();
            this.tbSendCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbBaudRate = new System.Windows.Forms.Label();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.lbParity = new System.Windows.Forms.Label();
            this.ParityComboBox = new System.Windows.Forms.ComboBox();
            this.lbStopBits = new System.Windows.Forms.Label();
            this.StopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSend = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cmbSendNewLine = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbSendFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textLen = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.prebarSendFile = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.WorkToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ClearToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.RecvCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SendCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tbRecvData, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(721, 490);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // tbRecvData
            // 
            this.tbRecvData.BackColor = System.Drawing.SystemColors.Window;
            this.tbRecvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRecvData.Location = new System.Drawing.Point(3, 3);
            this.tbRecvData.Multiline = true;
            this.tbRecvData.Name = "tbRecvData";
            this.tbRecvData.ReadOnly = true;
            this.tbRecvData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRecvData.Size = new System.Drawing.Size(715, 363);
            this.tbRecvData.TabIndex = 2;
            this.tbRecvData.TextChanged += new System.EventHandler(this.tbRecvData_TextChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 369);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(721, 121);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(715, 115);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(707, 89);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "串口设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(701, 83);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.chkShowTypeHex, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnLink, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.label3, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DataBitsComboBox, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.SerialNumberComboBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbDataBits, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbRecvCount, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbSendCount, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnClear, 5, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbBaudRate, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.BaudRateComboBox, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbParity, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.ParityComboBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbStopBits, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.StopBitsComboBox, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(90, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(611, 83);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // chkShowTypeHex
            // 
            this.chkShowTypeHex.AutoSize = true;
            this.chkShowTypeHex.Location = new System.Drawing.Point(378, 3);
            this.chkShowTypeHex.Name = "chkShowTypeHex";
            this.chkShowTypeHex.Size = new System.Drawing.Size(84, 16);
            this.chkShowTypeHex.TabIndex = 25;
            this.chkShowTypeHex.Text = "16进制显示";
            this.chkShowTypeHex.UseVisualStyleBackColor = true;
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(191, 57);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(64, 23);
            this.btnLink.TabIndex = 17;
            this.btnLink.Text = "连接";
            this.btnLink.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "串口号：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DataBitsComboBox
            // 
            this.DataBitsComboBox.FormattingEnabled = true;
            this.DataBitsComboBox.Location = new System.Drawing.Point(191, 30);
            this.DataBitsComboBox.Name = "DataBitsComboBox";
            this.DataBitsComboBox.Size = new System.Drawing.Size(64, 20);
            this.DataBitsComboBox.TabIndex = 14;
            // 
            // SerialNumberComboBox
            // 
            this.SerialNumberComboBox.FormattingEnabled = true;
            this.SerialNumberComboBox.Location = new System.Drawing.Point(62, 3);
            this.SerialNumberComboBox.Name = "SerialNumberComboBox";
            this.SerialNumberComboBox.Size = new System.Drawing.Size(64, 20);
            this.SerialNumberComboBox.TabIndex = 4;
            // 
            // lbDataBits
            // 
            this.lbDataBits.AutoSize = true;
            this.lbDataBits.Location = new System.Drawing.Point(132, 27);
            this.lbDataBits.Name = "lbDataBits";
            this.lbDataBits.Size = new System.Drawing.Size(53, 12);
            this.lbDataBits.TabIndex = 13;
            this.lbDataBits.Text = "数据位：";
            this.lbDataBits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbRecvCount
            // 
            this.tbRecvCount.BackColor = System.Drawing.SystemColors.Window;
            this.tbRecvCount.Location = new System.Drawing.Point(308, 3);
            this.tbRecvCount.Name = "tbRecvCount";
            this.tbRecvCount.ReadOnly = true;
            this.tbRecvCount.Size = new System.Drawing.Size(64, 21);
            this.tbRecvCount.TabIndex = 19;
            // 
            // tbSendCount
            // 
            this.tbSendCount.BackColor = System.Drawing.SystemColors.Window;
            this.tbSendCount.Location = new System.Drawing.Point(308, 30);
            this.tbSendCount.Name = "tbSendCount";
            this.tbSendCount.ReadOnly = true;
            this.tbSendCount.Size = new System.Drawing.Size(64, 21);
            this.tbSendCount.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "接收：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "发送：";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(308, 57);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "清空统计";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lbBaudRate
            // 
            this.lbBaudRate.AutoSize = true;
            this.lbBaudRate.Location = new System.Drawing.Point(132, 0);
            this.lbBaudRate.Name = "lbBaudRate";
            this.lbBaudRate.Size = new System.Drawing.Size(53, 12);
            this.lbBaudRate.TabIndex = 6;
            this.lbBaudRate.Text = "波特率：";
            this.lbBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Location = new System.Drawing.Point(191, 3);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(64, 20);
            this.BaudRateComboBox.TabIndex = 7;
            // 
            // lbParity
            // 
            this.lbParity.AutoSize = true;
            this.lbParity.Location = new System.Drawing.Point(3, 27);
            this.lbParity.Name = "lbParity";
            this.lbParity.Size = new System.Drawing.Size(53, 12);
            this.lbParity.TabIndex = 9;
            this.lbParity.Text = "校验位：";
            this.lbParity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ParityComboBox
            // 
            this.ParityComboBox.FormattingEnabled = true;
            this.ParityComboBox.Location = new System.Drawing.Point(62, 30);
            this.ParityComboBox.Name = "ParityComboBox";
            this.ParityComboBox.Size = new System.Drawing.Size(64, 20);
            this.ParityComboBox.TabIndex = 12;
            // 
            // lbStopBits
            // 
            this.lbStopBits.AutoSize = true;
            this.lbStopBits.Location = new System.Drawing.Point(3, 54);
            this.lbStopBits.Name = "lbStopBits";
            this.lbStopBits.Size = new System.Drawing.Size(53, 12);
            this.lbStopBits.TabIndex = 15;
            this.lbStopBits.Text = "停止位：";
            this.lbStopBits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StopBitsComboBox
            // 
            this.StopBitsComboBox.FormattingEnabled = true;
            this.StopBitsComboBox.Location = new System.Drawing.Point(62, 57);
            this.StopBitsComboBox.Name = "StopBitsComboBox";
            this.StopBitsComboBox.Size = new System.Drawing.Size(64, 20);
            this.StopBitsComboBox.TabIndex = 16;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(84, 76);
            this.listBox1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(707, 89);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "发送数据";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBox2, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(701, 83);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.AutoSize = true;
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Controls.Add(this.btnSend, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.textBox3, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.checkBox1, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.checkBox2, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.cmbSendNewLine, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(450, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 4;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(251, 83);
            this.tableLayoutPanel8.TabIndex = 11;
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend.Location = new System.Drawing.Point(3, 56);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(84, 27);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(164, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(64, 21);
            this.textBox3.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "16进制发送";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "发送间隔：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 29);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "自动发送";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // cmbSendNewLine
            // 
            this.cmbSendNewLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSendNewLine.FormattingEnabled = true;
            this.cmbSendNewLine.Items.AddRange(new object[] {
            "",
            "\\r\\n",
            "\\r",
            "\\n"});
            this.cmbSendNewLine.Location = new System.Drawing.Point(164, 3);
            this.cmbSendNewLine.Name = "cmbSendNewLine";
            this.cmbSendNewLine.Size = new System.Drawing.Size(64, 20);
            this.cmbSendNewLine.TabIndex = 11;
            this.cmbSendNewLine.SelectedIndexChanged += new System.EventHandler(this.cmbSendNewLine_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "发送空行：";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(444, 77);
            this.textBox2.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(707, 89);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "发送文件";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tbSendFile, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.textLen, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnOpenFile, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnSendFile, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.prebarSendFile, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(701, 83);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // tbSendFile
            // 
            this.tbSendFile.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel2.SetColumnSpan(this.tbSendFile, 6);
            this.tbSendFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSendFile.Location = new System.Drawing.Point(3, 3);
            this.tbSendFile.Name = "tbSendFile";
            this.tbSendFile.ReadOnly = true;
            this.tbSendFile.Size = new System.Drawing.Size(695, 21);
            this.tbSendFile.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "分包长度：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textLen
            // 
            this.textLen.Location = new System.Drawing.Point(74, 51);
            this.textLen.Name = "textLen";
            this.textLen.Size = new System.Drawing.Size(69, 21);
            this.textLen.TabIndex = 1;
            this.textLen.Text = "128";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(149, 51);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(69, 27);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "打开";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(224, 51);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(69, 27);
            this.btnSendFile.TabIndex = 3;
            this.btnSendFile.Text = "发送";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // prebarSendFile
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.prebarSendFile, 5);
            this.prebarSendFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prebarSendFile.Location = new System.Drawing.Point(74, 30);
            this.prebarSendFile.Name = "prebarSendFile";
            this.prebarSendFile.Size = new System.Drawing.Size(624, 15);
            this.prebarSendFile.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "发送进度：";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowToolStripStatusLabel,
            this.StatToolStripStatusLabel,
            this.toolStripStatusLabel1,
            this.SendCountToolStripStatusLabel,
            this.toolStripStatusLabel2,
            this.RecvCountToolStripStatusLabel,
            this.ClearToolStripStatusLabel,
            this.WorkToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(721, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // WorkToolStripStatusLabel
            // 
            this.WorkToolStripStatusLabel.Name = "WorkToolStripStatusLabel";
            this.WorkToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanel4);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(721, 490);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(721, 512);
            this.toolStripContainer1.TabIndex = 9;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // ClearToolStripStatusLabel
            // 
            this.ClearToolStripStatusLabel.IsLink = true;
            this.ClearToolStripStatusLabel.Name = "ClearToolStripStatusLabel";
            this.ClearToolStripStatusLabel.Size = new System.Drawing.Size(32, 17);
            this.ClearToolStripStatusLabel.Text = "清空";
            this.ClearToolStripStatusLabel.Click += new System.EventHandler(this.ClearToolStripStatusLabel_Click);
            // 
            // RecvCountToolStripStatusLabel
            // 
            this.RecvCountToolStripStatusLabel.Name = "RecvCountToolStripStatusLabel";
            this.RecvCountToolStripStatusLabel.Size = new System.Drawing.Size(43, 17);
            this.RecvCountToolStripStatusLabel.Text = "65535";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(25, 17);
            this.toolStripStatusLabel2.Text = "Rx:";
            // 
            // SendCountToolStripStatusLabel
            // 
            this.SendCountToolStripStatusLabel.Name = "SendCountToolStripStatusLabel";
            this.SendCountToolStripStatusLabel.Size = new System.Drawing.Size(43, 17);
            this.SendCountToolStripStatusLabel.Text = "65535";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(24, 17);
            this.toolStripStatusLabel1.Text = "Tx:";
            // 
            // StatToolStripStatusLabel
            // 
            this.StatToolStripStatusLabel.Name = "StatToolStripStatusLabel";
            this.StatToolStripStatusLabel.Size = new System.Drawing.Size(72, 17);
            this.StatToolStripStatusLabel.Text = "Sam Wong";
            // 
            // ShowToolStripStatusLabel
            // 
            this.ShowToolStripStatusLabel.Name = "ShowToolStripStatusLabel";
            this.ShowToolStripStatusLabel.Size = new System.Drawing.Size(89, 17);
            this.ShowToolStripStatusLabel.Text = "MUUMLOVER";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 512);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SerialFrom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.SerialFrom_Load);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox tbRecvData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textLen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbSendFile;
        private System.Windows.Forms.ProgressBar prebarSendFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ToolStripStatusLabel WorkToolStripStatusLabel;
        private System.Windows.Forms.ComboBox cmbSendNewLine;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox chkShowTypeHex;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DataBitsComboBox;
        private System.Windows.Forms.ComboBox SerialNumberComboBox;
        private System.Windows.Forms.Label lbDataBits;
        private System.Windows.Forms.TextBox tbRecvCount;
        private System.Windows.Forms.TextBox tbSendCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbBaudRate;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.Label lbParity;
        private System.Windows.Forms.ComboBox ParityComboBox;
        private System.Windows.Forms.Label lbStopBits;
        private System.Windows.Forms.ComboBox StopBitsComboBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripStatusLabel ShowToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel StatToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel SendCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel RecvCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ClearToolStripStatusLabel;
    }
}