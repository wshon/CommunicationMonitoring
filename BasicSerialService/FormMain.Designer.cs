namespace BasicSerialService
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
            this.layoutPane = new System.Windows.Forms.TableLayoutPanel();
            this.ParityComboBox = new System.Windows.Forms.ComboBox();
            this.StopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.DataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.lbParity = new System.Windows.Forms.Label();
            this.lbStopBits = new System.Windows.Forms.Label();
            this.lbDataBits = new System.Windows.Forms.Label();
            this.lbSerialNumber = new System.Windows.Forms.Label();
            this.lbBaudRate = new System.Windows.Forms.Label();
            this.SerialNumberComboBox = new System.Windows.Forms.ComboBox();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.addDeviceCancelButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.addDeviceOKButton = new System.Windows.Forms.Button();
            this.layoutPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPane
            // 
            this.layoutPane.BackColor = System.Drawing.Color.Transparent;
            this.layoutPane.ColumnCount = 4;
            this.layoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutPane.Controls.Add(this.ParityComboBox, 1, 3);
            this.layoutPane.Controls.Add(this.StopBitsComboBox, 1, 5);
            this.layoutPane.Controls.Add(this.DataBitsComboBox, 1, 4);
            this.layoutPane.Controls.Add(this.lbParity, 0, 3);
            this.layoutPane.Controls.Add(this.lbStopBits, 0, 5);
            this.layoutPane.Controls.Add(this.lbDataBits, 0, 4);
            this.layoutPane.Controls.Add(this.lbSerialNumber, 0, 1);
            this.layoutPane.Controls.Add(this.lbBaudRate, 0, 2);
            this.layoutPane.Controls.Add(this.SerialNumberComboBox, 1, 1);
            this.layoutPane.Controls.Add(this.BaudRateComboBox, 1, 2);
            this.layoutPane.Controls.Add(this.addDeviceCancelButton, 3, 7);
            this.layoutPane.Controls.Add(this.label6, 0, 0);
            this.layoutPane.Controls.Add(this.TitleTextBox, 1, 0);
            this.layoutPane.Controls.Add(this.addDeviceOKButton, 1, 7);
            this.layoutPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPane.Location = new System.Drawing.Point(0, 0);
            this.layoutPane.Margin = new System.Windows.Forms.Padding(0);
            this.layoutPane.Name = "layoutPane";
            this.layoutPane.RowCount = 8;
            this.layoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPane.Size = new System.Drawing.Size(239, 201);
            this.layoutPane.TabIndex = 8;
            // 
            // ParityComboBox
            // 
            this.ParityComboBox.FormattingEnabled = true;
            this.ParityComboBox.Location = new System.Drawing.Point(98, 82);
            this.ParityComboBox.Name = "ParityComboBox";
            this.ParityComboBox.Size = new System.Drawing.Size(120, 20);
            this.ParityComboBox.TabIndex = 11;
            // 
            // StopBitsComboBox
            // 
            this.StopBitsComboBox.FormattingEnabled = true;
            this.StopBitsComboBox.Location = new System.Drawing.Point(98, 134);
            this.StopBitsComboBox.Name = "StopBitsComboBox";
            this.StopBitsComboBox.Size = new System.Drawing.Size(120, 20);
            this.StopBitsComboBox.TabIndex = 10;
            // 
            // DataBitsComboBox
            // 
            this.DataBitsComboBox.FormattingEnabled = true;
            this.DataBitsComboBox.Location = new System.Drawing.Point(98, 108);
            this.DataBitsComboBox.Name = "DataBitsComboBox";
            this.DataBitsComboBox.Size = new System.Drawing.Size(120, 20);
            this.DataBitsComboBox.TabIndex = 9;
            // 
            // lbParity
            // 
            this.lbParity.AutoSize = true;
            this.lbParity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbParity.Location = new System.Drawing.Point(3, 79);
            this.lbParity.Name = "lbParity";
            this.lbParity.Size = new System.Drawing.Size(89, 26);
            this.lbParity.TabIndex = 8;
            this.lbParity.Text = "Parity:";
            this.lbParity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbStopBits
            // 
            this.lbStopBits.AutoSize = true;
            this.lbStopBits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStopBits.Location = new System.Drawing.Point(3, 131);
            this.lbStopBits.Name = "lbStopBits";
            this.lbStopBits.Size = new System.Drawing.Size(89, 26);
            this.lbStopBits.TabIndex = 7;
            this.lbStopBits.Text = "Stop Bits:";
            this.lbStopBits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDataBits
            // 
            this.lbDataBits.AutoSize = true;
            this.lbDataBits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDataBits.Location = new System.Drawing.Point(3, 105);
            this.lbDataBits.Name = "lbDataBits";
            this.lbDataBits.Size = new System.Drawing.Size(89, 26);
            this.lbDataBits.TabIndex = 6;
            this.lbDataBits.Text = "Data Bits:";
            this.lbDataBits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSerialNumber
            // 
            this.lbSerialNumber.AutoSize = true;
            this.lbSerialNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSerialNumber.Location = new System.Drawing.Point(3, 27);
            this.lbSerialNumber.Name = "lbSerialNumber";
            this.lbSerialNumber.Size = new System.Drawing.Size(89, 26);
            this.lbSerialNumber.TabIndex = 3;
            this.lbSerialNumber.Text = "Serial number:";
            this.lbSerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbBaudRate
            // 
            this.lbBaudRate.AutoSize = true;
            this.lbBaudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBaudRate.Location = new System.Drawing.Point(3, 53);
            this.lbBaudRate.Name = "lbBaudRate";
            this.lbBaudRate.Size = new System.Drawing.Size(89, 26);
            this.lbBaudRate.TabIndex = 5;
            this.lbBaudRate.Text = "Baud Rate:";
            this.lbBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SerialNumberComboBox
            // 
            this.SerialNumberComboBox.FormattingEnabled = true;
            this.SerialNumberComboBox.Location = new System.Drawing.Point(98, 30);
            this.SerialNumberComboBox.Name = "SerialNumberComboBox";
            this.SerialNumberComboBox.Size = new System.Drawing.Size(120, 20);
            this.SerialNumberComboBox.TabIndex = 2;
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Location = new System.Drawing.Point(98, 56);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(120, 20);
            this.BaudRateComboBox.TabIndex = 4;
            // 
            // addDeviceCancelButton
            // 
            this.addDeviceCancelButton.AutoSize = true;
            this.addDeviceCancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addDeviceCancelButton.Location = new System.Drawing.Point(176, 176);
            this.addDeviceCancelButton.Name = "addDeviceCancelButton";
            this.addDeviceCancelButton.Size = new System.Drawing.Size(60, 22);
            this.addDeviceCancelButton.TabIndex = 1;
            this.addDeviceCancelButton.Text = "Cancel";
            this.addDeviceCancelButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Windows Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(98, 3);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(120, 21);
            this.TitleTextBox.TabIndex = 13;
            // 
            // addDeviceOKButton
            // 
            this.addDeviceOKButton.AutoSize = true;
            this.layoutPane.SetColumnSpan(this.addDeviceOKButton, 2);
            this.addDeviceOKButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addDeviceOKButton.Location = new System.Drawing.Point(110, 176);
            this.addDeviceOKButton.Name = "addDeviceOKButton";
            this.addDeviceOKButton.Size = new System.Drawing.Size(60, 22);
            this.addDeviceOKButton.TabIndex = 0;
            this.addDeviceOKButton.Text = "OK";
            this.addDeviceOKButton.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 201);
            this.Controls.Add(this.layoutPane);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.layoutPane.ResumeLayout(false);
            this.layoutPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPane;
        private System.Windows.Forms.ComboBox ParityComboBox;
        private System.Windows.Forms.ComboBox StopBitsComboBox;
        private System.Windows.Forms.ComboBox DataBitsComboBox;
        private System.Windows.Forms.Label lbParity;
        private System.Windows.Forms.Label lbStopBits;
        private System.Windows.Forms.Label lbDataBits;
        private System.Windows.Forms.Label lbSerialNumber;
        private System.Windows.Forms.Label lbBaudRate;
        private System.Windows.Forms.ComboBox SerialNumberComboBox;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.Button addDeviceCancelButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button addDeviceOKButton;
    }
}

