namespace WinformException
{
    partial class FrmBugReport
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
            this.lblErrorCode = new System.Windows.Forms.Label();
            this.txtBugInfo = new System.Windows.Forms.TextBox();
            this.btnDetailsInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblErrorCode
            // 
            this.lblErrorCode.AutoSize = true;
            this.lblErrorCode.Location = new System.Drawing.Point(141, 104);
            this.lblErrorCode.Name = "lblErrorCode";
            this.lblErrorCode.Size = new System.Drawing.Size(41, 12);
            this.lblErrorCode.TabIndex = 0;
            this.lblErrorCode.Text = "label1";
            // 
            // txtBugInfo
            // 
            this.txtBugInfo.Location = new System.Drawing.Point(143, 12);
            this.txtBugInfo.Multiline = true;
            this.txtBugInfo.Name = "txtBugInfo";
            this.txtBugInfo.ReadOnly = true;
            this.txtBugInfo.Size = new System.Drawing.Size(204, 89);
            this.txtBugInfo.TabIndex = 2;
            // 
            // btnDetailsInfo
            // 
            this.btnDetailsInfo.Location = new System.Drawing.Point(154, 158);
            this.btnDetailsInfo.Name = "btnDetailsInfo";
            this.btnDetailsInfo.Size = new System.Drawing.Size(75, 23);
            this.btnDetailsInfo.TabIndex = 3;
            this.btnDetailsInfo.Text = "button1";
            this.btnDetailsInfo.UseVisualStyleBackColor = true;
            this.btnDetailsInfo.Click += new System.EventHandler(this.btnDetailsInfo_Click);
            // 
            // FrmBugReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 307);
            this.Controls.Add(this.btnDetailsInfo);
            this.Controls.Add(this.txtBugInfo);
            this.Controls.Add(this.lblErrorCode);
            this.Name = "FrmBugReport";
            this.Text = "FrmBugReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorCode;
        private System.Windows.Forms.TextBox txtBugInfo;
        private System.Windows.Forms.Button btnDetailsInfo;
    }
}