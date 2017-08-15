using System.Windows.Forms;

namespace VirtualSerialMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.btnCreatePort = new System.Windows.Forms.Button();
            this.strPort1 = new System.Windows.Forms.TextBox();
            this.strPort2 = new System.Windows.Forms.TextBox();
            this.btnCreatePair = new System.Windows.Forms.Button();
            this.btnResetBus = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textLen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbSettings = new System.Windows.Forms.Label();
            this.textRecv = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textSent = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.tbSettings = new System.Windows.Forms.TextBox();
            this.btnRi = new System.Windows.Forms.Button();
            this.btnDcd = new System.Windows.Forms.Button();
            this.btnDsr = new System.Windows.Forms.Button();
            this.btnCts = new System.Windows.Forms.Button();
            this.editLog = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.editTerminal = new System.Windows.Forms.TextBox();
            this.chkStrict = new System.Windows.Forms.CheckBox();
            this.chkBreak = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelMask = new System.Windows.Forms.Button();
            this.btnAddMask = new System.Windows.Forms.Button();
            this.cmbAllow = new System.Windows.Forms.ComboBox();
            this.tbMask = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.axVSPortAx3 = new AxVSPortLib.AxVSPortAx();
            this.axVSPortAx4 = new AxVSPortLib.AxVSPortAx();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVSPortAx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVSPortAx4)).BeginInit();
            this.SuspendLayout();
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.Location = new System.Drawing.Point(11, 16);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(52, 17);
            this.label30.TabIndex = 2;
            this.label30.Text = "Port 1";
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.Location = new System.Drawing.Point(11, 38);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(52, 17);
            this.label31.TabIndex = 3;
            this.label31.Text = "Port 2";
            // 
            // btnCreatePort
            // 
            this.btnCreatePort.Location = new System.Drawing.Point(183, 12);
            this.btnCreatePort.Name = "btnCreatePort";
            this.btnCreatePort.Size = new System.Drawing.Size(90, 21);
            this.btnCreatePort.TabIndex = 5;
            this.btnCreatePort.Text = "Create port";
            this.btnCreatePort.Click += new System.EventHandler(this.btnCreatePort_Click);
            // 
            // strPort1
            // 
            this.strPort1.Location = new System.Drawing.Point(68, 12);
            this.strPort1.Name = "strPort1";
            this.strPort1.Size = new System.Drawing.Size(111, 21);
            this.strPort1.TabIndex = 6;
            this.strPort1.Text = "COM6";
            // 
            // strPort2
            // 
            this.strPort2.Location = new System.Drawing.Point(68, 38);
            this.strPort2.Name = "strPort2";
            this.strPort2.Size = new System.Drawing.Size(111, 21);
            this.strPort2.TabIndex = 8;
            this.strPort2.Text = "COM7";
            // 
            // btnCreatePair
            // 
            this.btnCreatePair.Location = new System.Drawing.Point(183, 38);
            this.btnCreatePair.Name = "btnCreatePair";
            this.btnCreatePair.Size = new System.Drawing.Size(90, 21);
            this.btnCreatePair.TabIndex = 7;
            this.btnCreatePair.Text = "Create pair";
            this.btnCreatePair.Click += new System.EventHandler(this.btnCreatePair_Click);
            // 
            // btnResetBus
            // 
            this.btnResetBus.Location = new System.Drawing.Point(279, 38);
            this.btnResetBus.Name = "btnResetBus";
            this.btnResetBus.Size = new System.Drawing.Size(284, 21);
            this.btnResetBus.TabIndex = 9;
            this.btnResetBus.Text = "Reset Bus";
            this.btnResetBus.Click += new System.EventHandler(this.btnResetBus_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(279, 12);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(90, 21);
            this.btnSendFile.TabIndex = 10;
            this.btnSendFile.Text = "Send file";
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(371, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "by blocks of";
            // 
            // textLen
            // 
            this.textLen.Location = new System.Drawing.Point(447, 12);
            this.textLen.Name = "textLen";
            this.textLen.Size = new System.Drawing.Size(72, 21);
            this.textLen.TabIndex = 12;
            this.textLen.Text = "128";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(519, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "bytes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbSettings);
            this.groupBox3.Controls.Add(this.textRecv);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.textSent);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnSettings);
            this.groupBox3.Controls.Add(this.tbSettings);
            this.groupBox3.Controls.Add(this.btnRi);
            this.groupBox3.Controls.Add(this.btnDcd);
            this.groupBox3.Controls.Add(this.btnDsr);
            this.groupBox3.Controls.Add(this.btnCts);
            this.groupBox3.Location = new System.Drawing.Point(11, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(552, 103);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Port 1 settings";
            // 
            // lbSettings
            // 
            this.lbSettings.Enabled = false;
            this.lbSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSettings.Location = new System.Drawing.Point(12, 22);
            this.lbSettings.Name = "lbSettings";
            this.lbSettings.Size = new System.Drawing.Size(245, 21);
            this.lbSettings.TabIndex = 35;
            this.lbSettings.Text = "Current port settings: closed";
            // 
            // textRecv
            // 
            this.textRecv.Enabled = false;
            this.textRecv.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.textRecv.Location = new System.Drawing.Point(478, 22);
            this.textRecv.Name = "textRecv";
            this.textRecv.Size = new System.Drawing.Size(62, 19);
            this.textRecv.TabIndex = 34;
            this.textRecv.Text = "0";
            this.textRecv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Enabled = false;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.Location = new System.Drawing.Point(372, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 19);
            this.label16.TabIndex = 33;
            this.label16.Text = "AX received:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textSent
            // 
            this.textSent.Enabled = false;
            this.textSent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.textSent.Location = new System.Drawing.Point(324, 22);
            this.textSent.Name = "textSent";
            this.textSent.Size = new System.Drawing.Size(55, 18);
            this.textSent.TabIndex = 32;
            this.textSent.Text = "0";
            this.textSent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(250, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 31;
            this.label10.Text = "AX sent:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSettings
            // 
            this.btnSettings.Enabled = false;
            this.btnSettings.Location = new System.Drawing.Point(415, 46);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(127, 22);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Set settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // tbSettings
            // 
            this.tbSettings.Enabled = false;
            this.tbSettings.Location = new System.Drawing.Point(12, 46);
            this.tbSettings.Name = "tbSettings";
            this.tbSettings.Size = new System.Drawing.Size(396, 21);
            this.tbSettings.TabIndex = 4;
            this.tbSettings.Text = "9600,N,8,1";
            // 
            // btnRi
            // 
            this.btnRi.Enabled = false;
            this.btnRi.Location = new System.Drawing.Point(415, 74);
            this.btnRi.Name = "btnRi";
            this.btnRi.Size = new System.Drawing.Size(127, 22);
            this.btnRi.TabIndex = 3;
            this.btnRi.Text = "Set RING ON";
            this.btnRi.Click += new System.EventHandler(this.btnRi_Click);
            // 
            // btnDcd
            // 
            this.btnDcd.Enabled = false;
            this.btnDcd.Location = new System.Drawing.Point(281, 74);
            this.btnDcd.Name = "btnDcd";
            this.btnDcd.Size = new System.Drawing.Size(127, 22);
            this.btnDcd.TabIndex = 2;
            this.btnDcd.Text = "Set DCD OFF";
            this.btnDcd.Click += new System.EventHandler(this.btnDcd_Click);
            // 
            // btnDsr
            // 
            this.btnDsr.Enabled = false;
            this.btnDsr.Location = new System.Drawing.Point(146, 74);
            this.btnDsr.Name = "btnDsr";
            this.btnDsr.Size = new System.Drawing.Size(128, 22);
            this.btnDsr.TabIndex = 1;
            this.btnDsr.Text = "Ser DSR OFF";
            this.btnDsr.Click += new System.EventHandler(this.btnDsr_Click);
            // 
            // btnCts
            // 
            this.btnCts.Enabled = false;
            this.btnCts.Location = new System.Drawing.Point(12, 74);
            this.btnCts.Name = "btnCts";
            this.btnCts.Size = new System.Drawing.Size(127, 22);
            this.btnCts.TabIndex = 0;
            this.btnCts.Text = "Set CTS OFF";
            this.btnCts.Click += new System.EventHandler(this.btnCts_Click);
            // 
            // editLog
            // 
            this.editLog.Location = new System.Drawing.Point(11, 334);
            this.editLog.Multiline = true;
            this.editLog.Name = "editLog";
            this.editLog.ReadOnly = true;
            this.editLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.editLog.Size = new System.Drawing.Size(552, 60);
            this.editLog.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(11, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Terminal emulation (refers to Port 1)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editTerminal
            // 
            this.editTerminal.Location = new System.Drawing.Point(11, 416);
            this.editTerminal.Multiline = true;
            this.editTerminal.Name = "editTerminal";
            this.editTerminal.ReadOnly = true;
            this.editTerminal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.editTerminal.Size = new System.Drawing.Size(552, 43);
            this.editTerminal.TabIndex = 19;
            this.editTerminal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editTerminal_KeyPress);
            // 
            // chkStrict
            // 
            this.chkStrict.Location = new System.Drawing.Point(284, 459);
            this.chkStrict.Name = "chkStrict";
            this.chkStrict.Size = new System.Drawing.Size(139, 26);
            this.chkStrict.TabIndex = 20;
            this.chkStrict.Text = "Emulate baudrate";
            this.chkStrict.CheckedChanged += new System.EventHandler(this.chkStrict_CheckedChanged);
            // 
            // chkBreak
            // 
            this.chkBreak.Location = new System.Drawing.Point(433, 459);
            this.chkBreak.Name = "chkBreak";
            this.chkBreak.Size = new System.Drawing.Size(144, 26);
            this.chkBreak.TabIndex = 21;
            this.chkBreak.Text = "Emulate line break";
            this.chkBreak.CheckedChanged += new System.EventHandler(this.chkBreak_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Log data";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelMask);
            this.groupBox2.Controls.Add(this.btnAddMask);
            this.groupBox2.Controls.Add(this.cmbAllow);
            this.groupBox2.Controls.Add(this.tbMask);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(11, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 107);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port 1 access list";
            // 
            // btnDelMask
            // 
            this.btnDelMask.Enabled = false;
            this.btnDelMask.Location = new System.Drawing.Point(451, 78);
            this.btnDelMask.Name = "btnDelMask";
            this.btnDelMask.Size = new System.Drawing.Size(90, 21);
            this.btnDelMask.TabIndex = 4;
            this.btnDelMask.Text = "Del mask";
            this.btnDelMask.Click += new System.EventHandler(this.btnDelMask_Click);
            // 
            // btnAddMask
            // 
            this.btnAddMask.Enabled = false;
            this.btnAddMask.Location = new System.Drawing.Point(350, 78);
            this.btnAddMask.Name = "btnAddMask";
            this.btnAddMask.Size = new System.Drawing.Size(90, 21);
            this.btnAddMask.TabIndex = 3;
            this.btnAddMask.Text = "Add mask";
            this.btnAddMask.Click += new System.EventHandler(this.btnAddMask_Click);
            // 
            // cmbAllow
            // 
            this.cmbAllow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAllow.Enabled = false;
            this.cmbAllow.Items.AddRange(new object[] {
            "Deny",
            "Allow"});
            this.cmbAllow.Location = new System.Drawing.Point(254, 78);
            this.cmbAllow.Name = "cmbAllow";
            this.cmbAllow.Size = new System.Drawing.Size(87, 20);
            this.cmbAllow.TabIndex = 2;
            // 
            // tbMask
            // 
            this.tbMask.Enabled = false;
            this.tbMask.Location = new System.Drawing.Point(14, 78);
            this.tbMask.Name = "tbMask";
            this.tbMask.Size = new System.Drawing.Size(236, 21);
            this.tbMask.TabIndex = 1;
            this.tbMask.Text = "C:\\*.*";
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(14, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(524, 40);
            this.listBox1.TabIndex = 0;
            // 
            // axVSPortAx3
            // 
            this.axVSPortAx3.Enabled = true;
            this.axVSPortAx3.Location = new System.Drawing.Point(-1, 459);
            this.axVSPortAx3.Name = "axVSPortAx3";
            this.axVSPortAx3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVSPortAx3.OcxState")));
            this.axVSPortAx3.Size = new System.Drawing.Size(32, 32);
            this.axVSPortAx3.TabIndex = 28;
            // 
            // axVSPortAx4
            // 
            this.axVSPortAx4.Enabled = true;
            this.axVSPortAx4.Location = new System.Drawing.Point(68, 465);
            this.axVSPortAx4.Name = "axVSPortAx4";
            this.axVSPortAx4.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVSPortAx4.OcxState")));
            this.axVSPortAx4.Size = new System.Drawing.Size(32, 32);
            this.axVSPortAx4.TabIndex = 29;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(588, 496);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkBreak);
            this.Controls.Add(this.chkStrict);
            this.Controls.Add(this.editTerminal);
            this.Controls.Add(this.editLog);
            this.Controls.Add(this.textLen);
            this.Controls.Add(this.strPort2);
            this.Controls.Add(this.strPort1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.btnResetBus);
            this.Controls.Add(this.btnCreatePair);
            this.Controls.Add(this.btnCreatePort);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "C# Example (VSP ActiveX Control)";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreatePort;
        private System.Windows.Forms.Button btnCreatePair;
        private System.Windows.Forms.Button btnResetBus;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox editLog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkStrict;
        private System.Windows.Forms.CheckBox chkBreak;
        private System.Windows.Forms.TextBox editTerminal;
        private System.Windows.Forms.Button btnDsr;
        private System.Windows.Forms.Button btnCts;
        private System.Windows.Forms.Button btnDcd;
        private System.Windows.Forms.Button btnRi;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox strPort1;
        private System.Windows.Forms.TextBox strPort2;
        private System.Windows.Forms.TextBox textLen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbSettings;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label textRecv;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label textSent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbSettings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbAllow;
        private System.Windows.Forms.Button btnAddMask;
        private System.Windows.Forms.Button btnDelMask;
        private System.Windows.Forms.TextBox tbMask;
        private AxVSPortLib.AxVSPortAx axVSPortAx3;
        private AxVSPortLib.AxVSPortAx axVSPortAx4;
    }
}