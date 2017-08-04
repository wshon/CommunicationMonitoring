namespace CommunicationMonitoring
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeviceAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDeviceRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.deviceDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.systemToolStripMenuItem.Text = "System(&S)";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "Exit(&X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // deviceDToolStripMenuItem
            // 
            this.deviceDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDeviceAToolStripMenuItem,
            this.removeDeviceRToolStripMenuItem});
            this.deviceDToolStripMenuItem.Name = "deviceDToolStripMenuItem";
            this.deviceDToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.deviceDToolStripMenuItem.Text = "Device(&D)";
            // 
            // addDeviceAToolStripMenuItem
            // 
            this.addDeviceAToolStripMenuItem.Name = "addDeviceAToolStripMenuItem";
            this.addDeviceAToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.addDeviceAToolStripMenuItem.Text = "AddDevice(&A)";
            this.addDeviceAToolStripMenuItem.Click += new System.EventHandler(this.addDeviceAToolStripMenuItem_Click);
            // 
            // removeDeviceRToolStripMenuItem
            // 
            this.removeDeviceRToolStripMenuItem.Name = "removeDeviceRToolStripMenuItem";
            this.removeDeviceRToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.removeDeviceRToolStripMenuItem.Text = "RemoveDevice(&R)";
            this.removeDeviceRToolStripMenuItem.Click += new System.EventHandler(this.removeDeviceRToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommunicationMonitoring";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem deviceDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDeviceAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDeviceRToolStripMenuItem;
    }
}

