namespace BasicSocketClient
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutPane = new System.Windows.Forms.TableLayoutPanel();
            this.lbSerialNumber = new System.Windows.Forms.Label();
            this.SocketIPComboBox = new System.Windows.Forms.ComboBox();
            this.lbBaudRate = new System.Windows.Forms.Label();
            this.SocketPortComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addDeviceOKButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.layoutPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutPane
            // 
            this.layoutPane.BackColor = System.Drawing.Color.Transparent;
            this.layoutPane.ColumnCount = 5;
            this.layoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPane.Controls.Add(this.lbSerialNumber, 0, 1);
            this.layoutPane.Controls.Add(this.SocketIPComboBox, 1, 1);
            this.layoutPane.Controls.Add(this.lbBaudRate, 0, 2);
            this.layoutPane.Controls.Add(this.SocketPortComboBox, 1, 2);
            this.layoutPane.Controls.Add(this.label1, 0, 3);
            this.layoutPane.Controls.Add(this.addDeviceOKButton, 1, 3);
            this.layoutPane.Controls.Add(this.button1, 4, 3);
            this.layoutPane.Controls.Add(this.textBox1, 4, 1);
            this.layoutPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPane.Location = new System.Drawing.Point(0, 0);
            this.layoutPane.Name = "layoutPane";
            this.layoutPane.RowCount = 5;
            this.layoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPane.Size = new System.Drawing.Size(770, 95);
            this.layoutPane.TabIndex = 9;
            // 
            // lbSerialNumber
            // 
            this.lbSerialNumber.AutoSize = true;
            this.lbSerialNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSerialNumber.Location = new System.Drawing.Point(3, 7);
            this.lbSerialNumber.Name = "lbSerialNumber";
            this.lbSerialNumber.Size = new System.Drawing.Size(77, 26);
            this.lbSerialNumber.TabIndex = 3;
            this.lbSerialNumber.Text = "Server IP:";
            this.lbSerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SocketIPComboBox
            // 
            this.SocketIPComboBox.FormattingEnabled = true;
            this.SocketIPComboBox.Items.AddRange(new object[] {
            "127.0.0.1"});
            this.SocketIPComboBox.Location = new System.Drawing.Point(86, 10);
            this.SocketIPComboBox.Name = "SocketIPComboBox";
            this.SocketIPComboBox.Size = new System.Drawing.Size(120, 20);
            this.SocketIPComboBox.TabIndex = 2;
            this.SocketIPComboBox.Text = "127.0.0.1";
            // 
            // lbBaudRate
            // 
            this.lbBaudRate.AutoSize = true;
            this.lbBaudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBaudRate.Location = new System.Drawing.Point(3, 33);
            this.lbBaudRate.Name = "lbBaudRate";
            this.lbBaudRate.Size = new System.Drawing.Size(77, 26);
            this.lbBaudRate.TabIndex = 5;
            this.lbBaudRate.Text = "Server Port:";
            this.lbBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SocketPortComboBox
            // 
            this.SocketPortComboBox.FormattingEnabled = true;
            this.SocketPortComboBox.Items.AddRange(new object[] {
            "1234",
            "5000",
            "5001",
            "5002"});
            this.SocketPortComboBox.Location = new System.Drawing.Point(86, 36);
            this.SocketPortComboBox.Name = "SocketPortComboBox";
            this.SocketPortComboBox.Size = new System.Drawing.Size(120, 20);
            this.SocketPortComboBox.TabIndex = 4;
            this.SocketPortComboBox.Text = "5000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addDeviceOKButton
            // 
            this.addDeviceOKButton.AutoSize = true;
            this.addDeviceOKButton.Location = new System.Drawing.Point(86, 62);
            this.addDeviceOKButton.Name = "addDeviceOKButton";
            this.addDeviceOKButton.Size = new System.Drawing.Size(120, 22);
            this.addDeviceOKButton.TabIndex = 0;
            this.addDeviceOKButton.Text = "OK";
            this.addDeviceOKButton.UseVisualStyleBackColor = true;
            this.addDeviceOKButton.Click += new System.EventHandler(this.addDeviceOKButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.layoutPane.SetRowSpan(this.textBox1, 2);
            this.textBox1.Size = new System.Drawing.Size(246, 46);
            this.textBox1.TabIndex = 16;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 95);
            this.Controls.Add(this.layoutPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "TCP客户端";
            this.layoutPane.ResumeLayout(false);
            this.layoutPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPane;
        private System.Windows.Forms.Label lbSerialNumber;
        private System.Windows.Forms.ComboBox SocketIPComboBox;
        private System.Windows.Forms.Label lbBaudRate;
        private System.Windows.Forms.ComboBox SocketPortComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addDeviceOKButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

