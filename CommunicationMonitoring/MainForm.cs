using LanguageResource;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace CommunicationMonitoring
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ResourceCulture.SetCurrentCulture("zh-CN");
            ResourceCulture.SetResourceCulture(menuStrip1.Items, Assembly.GetExecutingAssembly());
            //this.SetResourceCulture(menuStrip1.Items);
            //toolToolStripMenuItem;
            reloadExTool();
        }

        private void reloadRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reloadExTool();
        }

        private void reloadExTool()
        {
            int thisCount = toolToolStripMenuItem.DropDownItems.Count;
            for (int i = 2; i < thisCount; i++)
            {
                toolToolStripMenuItem.DropDownItems.RemoveAt(toolToolStripMenuItem.DropDownItems.Count - 1);
            }
            
            DirectoryInfo TheFolder = new DirectoryInfo(".\\ExTool\\");
            if (TheFolder.Exists)
            {
                foreach (FileInfo file in TheFolder.GetFiles())
                {
                    if (file.Extension == ".dll")
                    {
                        Debug.WriteLine("Find dll:" + file.Name);
                        if (PageMamage.LoadType(".\\ExTool\\" + file.Name, "ui") != null)
                        {
                            Debug.WriteLine(file.Name + " is effective!\r\n");
                            toolToolStripMenuItem.DropDownItems.Add(file.Name, null, externToolStripMenuItem_Click);
                        }
                    }
                }
            }
        }

        private void externToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PageMamage().LoadPage(".\\ExTool\\" + (sender as ToolStripMenuItem).Text, "ui", this);
        }
        

        private void SetResourceCulture(ToolStripItemCollection items)

        {
            //遍历所有控件
            foreach (ToolStripMenuItem item in items)
            {
                string strTextTmp = item.Text;
                if (ResourceCulture.GetString(item.Name + "_Text", ref strTextTmp, Assembly.GetExecutingAssembly()))
                    item.Text = strTextTmp;
                if ((item.DropDownItems.Count != 0))
                {
                    SetResourceCulture(item.DropDownItems);
                }
            }
        }

        private void addDeviceAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MamageFormOpen(MamageForm.OpenMode.AddFrom);
        }

        private void removeDeviceRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MamageFormOpen(MamageForm.OpenMode.RemoveFrom);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MamageFormOpen(MamageForm.OpenMode userOpenMode)
        {
            foreach (Form childFrm in Application.OpenForms)
            {
                //用子窗体的Name进行判断，如果已经存在则将他激活
                if (childFrm.Name == "MamageForm")
                {
                    if (childFrm.WindowState == FormWindowState.Minimized)
                        childFrm.WindowState = FormWindowState.Normal;
                    //childFrm = new MamageForm(this, MamageForm.OpenMode.AddFrom);
                    childFrm.Activate();
                    return;
                }
            }
            new MamageForm(this, userOpenMode).Show();
        }

        private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new Exception("啊..我这行代码异常了...");
        }

        private void test2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() => { throw new Exception("啊哦，异常错误。"); });
            th.IsBackground = true;
            th.Start();
        }

        private void simplifiedChineseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
