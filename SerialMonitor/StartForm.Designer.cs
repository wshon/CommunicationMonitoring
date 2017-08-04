namespace SerialMonitor
{
    partial class StartForm
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
            this.layoutPane = new System.Windows.Forms.TableLayoutPanel();
            this.ParityComboBox = new System.Windows.Forms.ComboBox();
            this.StopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.DataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.layoutPane.Controls.Add(this.label5, 0, 3);
            this.layoutPane.Controls.Add(this.label4, 0, 5);
            this.layoutPane.Controls.Add(this.label3, 0, 4);
            this.layoutPane.Controls.Add(this.label1, 0, 1);
            this.layoutPane.Controls.Add(this.label2, 0, 2);
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
            this.layoutPane.Size = new System.Drawing.Size(320, 240);
            this.layoutPane.TabIndex = 7;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Parity:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stop Bits:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Bits:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Serial number:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Baud Rate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.addDeviceCancelButton.Location = new System.Drawing.Point(257, 215);
            this.addDeviceCancelButton.Name = "addDeviceCancelButton";
            this.addDeviceCancelButton.Size = new System.Drawing.Size(60, 22);
            this.addDeviceCancelButton.TabIndex = 1;
            this.addDeviceCancelButton.Text = "Cancel";
            this.addDeviceCancelButton.UseVisualStyleBackColor = true;
            this.addDeviceCancelButton.Click += new System.EventHandler(this.addDeviceCancelButton_Click);
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
            this.addDeviceOKButton.Location = new System.Drawing.Point(191, 215);
            this.addDeviceOKButton.Name = "addDeviceOKButton";
            this.addDeviceOKButton.Size = new System.Drawing.Size(60, 22);
            this.addDeviceOKButton.TabIndex = 0;
            this.addDeviceOKButton.Text = "OK";
            this.addDeviceOKButton.UseVisualStyleBackColor = true;
            this.addDeviceOKButton.Click += new System.EventHandler(this.addDeviceOKButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 240);
            this.Controls.Add(this.layoutPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.Text = "SerialMonitor";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.layoutPane.ResumeLayout(false);
            this.layoutPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPane;
        private System.Windows.Forms.ComboBox ParityComboBox;
        private System.Windows.Forms.ComboBox StopBitsComboBox;
        private System.Windows.Forms.ComboBox DataBitsComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SerialNumberComboBox;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.Button addDeviceCancelButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button addDeviceOKButton;
    }
}