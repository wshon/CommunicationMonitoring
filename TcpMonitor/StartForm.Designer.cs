namespace SocketMonitor
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
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.addDeviceCancelButton = new System.Windows.Forms.Button();
            this.addDeviceOKButton = new System.Windows.Forms.Button();
            this.layoutPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPane
            // 
            this.layoutPane.BackColor = System.Drawing.Color.Transparent;
            this.layoutPane.ColumnCount = 4;
            this.layoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutPane.Controls.Add(this.comboBox5, 1, 2);
            this.layoutPane.Controls.Add(this.comboBox4, 1, 4);
            this.layoutPane.Controls.Add(this.comboBox3, 1, 3);
            this.layoutPane.Controls.Add(this.label5, 0, 2);
            this.layoutPane.Controls.Add(this.label4, 0, 4);
            this.layoutPane.Controls.Add(this.label3, 0, 3);
            this.layoutPane.Controls.Add(this.label1, 0, 0);
            this.layoutPane.Controls.Add(this.label2, 0, 1);
            this.layoutPane.Controls.Add(this.comboBox1, 1, 0);
            this.layoutPane.Controls.Add(this.comboBox2, 1, 1);
            this.layoutPane.Controls.Add(this.addDeviceCancelButton, 3, 6);
            this.layoutPane.Controls.Add(this.addDeviceOKButton, 2, 6);
            this.layoutPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPane.Location = new System.Drawing.Point(0, 0);
            this.layoutPane.Margin = new System.Windows.Forms.Padding(0);
            this.layoutPane.Name = "layoutPane";
            this.layoutPane.RowCount = 7;
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
            // comboBox5
            // 
            this.layoutPane.SetColumnSpan(this.comboBox5, 3);
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(98, 55);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 20);
            this.comboBox5.TabIndex = 11;
            // 
            // comboBox4
            // 
            this.layoutPane.SetColumnSpan(this.comboBox4, 3);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(98, 107);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 20);
            this.comboBox4.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.layoutPane.SetColumnSpan(this.comboBox3, 3);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(98, 81);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 52);
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
            this.label4.Location = new System.Drawing.Point(3, 104);
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
            this.label3.Location = new System.Drawing.Point(3, 78);
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
            this.label1.Location = new System.Drawing.Point(3, 0);
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
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Baud Rate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.layoutPane.SetColumnSpan(this.comboBox1, 3);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.layoutPane.SetColumnSpan(this.comboBox2, 3);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(98, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 4;
            // 
            // addDeviceCancelButton
            // 
            this.addDeviceCancelButton.AutoSize = true;
            this.addDeviceCancelButton.Location = new System.Drawing.Point(257, 215);
            this.addDeviceCancelButton.Name = "addDeviceCancelButton";
            this.addDeviceCancelButton.Size = new System.Drawing.Size(60, 22);
            this.addDeviceCancelButton.TabIndex = 1;
            this.addDeviceCancelButton.Text = "Cancel";
            this.addDeviceCancelButton.UseVisualStyleBackColor = true;
            this.addDeviceCancelButton.Click += new System.EventHandler(this.addDeviceCancelButton_Click);
            // 
            // addDeviceOKButton
            // 
            this.addDeviceOKButton.AutoSize = true;
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
            this.Text = "SocketMonitor";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.layoutPane.ResumeLayout(false);
            this.layoutPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPane;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button addDeviceCancelButton;
        private System.Windows.Forms.Button addDeviceOKButton;
    }
}