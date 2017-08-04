namespace CommunicationMonitoring
{
    partial class MamageForm
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
            this.mamageTabControl = new System.Windows.Forms.TabControl();
            this.addDeviceTabPage = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.removeDeviceTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.serialPortBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.mamageTabControl.SuspendLayout();
            this.addDeviceTabPage.SuspendLayout();
            this.removeDeviceTabPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialPortBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mamageTabControl
            // 
            this.mamageTabControl.Controls.Add(this.addDeviceTabPage);
            this.mamageTabControl.Controls.Add(this.removeDeviceTabPage);
            this.mamageTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mamageTabControl.Location = new System.Drawing.Point(0, 0);
            this.mamageTabControl.Name = "mamageTabControl";
            this.mamageTabControl.SelectedIndex = 0;
            this.mamageTabControl.Size = new System.Drawing.Size(282, 261);
            this.mamageTabControl.TabIndex = 1;
            this.mamageTabControl.SelectedIndexChanged += new System.EventHandler(this.MamageTabControl_SelectedIndexChanged);
            // 
            // addDeviceTabPage
            // 
            this.addDeviceTabPage.Controls.Add(this.tabControl);
            this.addDeviceTabPage.Location = new System.Drawing.Point(4, 22);
            this.addDeviceTabPage.Name = "addDeviceTabPage";
            this.addDeviceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addDeviceTabPage.Size = new System.Drawing.Size(274, 235);
            this.addDeviceTabPage.TabIndex = 0;
            this.addDeviceTabPage.Text = "addDevice";
            this.addDeviceTabPage.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(268, 229);
            this.tabControl.TabIndex = 0;
            // 
            // removeDeviceTabPage
            // 
            this.removeDeviceTabPage.Controls.Add(this.tableLayoutPanel2);
            this.removeDeviceTabPage.Location = new System.Drawing.Point(4, 22);
            this.removeDeviceTabPage.Name = "removeDeviceTabPage";
            this.removeDeviceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.removeDeviceTabPage.Size = new System.Drawing.Size(274, 235);
            this.removeDeviceTabPage.TabIndex = 1;
            this.removeDeviceTabPage.Text = "removeDevice";
            this.removeDeviceTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.77612F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.22388F));
            this.tableLayoutPanel2.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.deleteButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(268, 229);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(181, 223);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // serialPortBindingSource
            // 
            this.serialPortBindingSource.DataSource = typeof(System.IO.Ports.SerialPort);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.SystemColors.Control;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(262, 1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.exitButton.Size = new System.Drawing.Size(18, 18);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "×";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(190, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MamageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 261);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mamageTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MamageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MamageForm";
            this.Load += new System.EventHandler(this.MamageForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MamageForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MamageForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MamageForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MamageForm_MouseUp);
            this.mamageTabControl.ResumeLayout(false);
            this.addDeviceTabPage.ResumeLayout(false);
            this.removeDeviceTabPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serialPortBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl mamageTabControl;
        private System.Windows.Forms.TabPage addDeviceTabPage;
        private System.Windows.Forms.TabPage removeDeviceTabPage;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.BindingSource serialPortBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button deleteButton;
    }
}