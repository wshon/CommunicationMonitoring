using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace CommunicationMonitoring
{
    public class PageMamage
    {
        /// <summary>
        /// 加载外部目录下所有dll到TabControl，并统计数量
        /// </summary>
        /// <param name="tabControltmp">加载到的TabControl</param>
        /// <param name="TheFolder">外部目录</param>
        /// <param name="modelLoadPass">加载成功dll数</param>
        /// <param name="modelLoadFail">加载失败dll数</param>
        public void ExternMode_Load(TabControl tabControltmp, String assType, DirectoryInfo TheFolder, ref int modelLoadPass, ref int modelLoadFail)
        {
            foreach (FileInfo file in TheFolder.GetFiles())
            {
                if (file.Extension == ".dll")
                {
                    Debug.WriteLine("Find dll:" + file.Name);
                    if (LoadPage(".\\" + file.Name, assType, tabControltmp))
                    {
                        Debug.WriteLine(file.Name + " is effective!\r\n");
                        modelLoadPass++;
                    }
                    else
                    {
                        Debug.WriteLine(file.Name + " is ineffective!\r\n");
                        modelLoadFail++;
                    }
                }
            }
        }
        /// <summary>
        /// 加载主程序目录下所有dll到TabControl，并统计数量
        /// </summary>
        /// <param name="tabControltmp">加载到的TabControl</param>
        /// <param name="modelLoadPass">加载成功dll数</param>
        /// <param name="modelLoadFail">加载失败dll数</param>
        public void ExternMode_Load(TabControl tabControltmp, String assType, ref int modelLoadPass, ref int modelLoadFail)
        {
            /*加载model*/
            //C#遍历models文件夹中的所有文件 
            DirectoryInfo TheFolder = new DirectoryInfo(".\\");
            if (TheFolder.Exists == false) TheFolder.Create();
            ExternMode_Load(tabControltmp, assType, TheFolder, ref modelLoadPass, ref modelLoadFail);
        }
        /// <summary>
        /// 加载指定文件夹下的所有dll到TabControl
        /// </summary>
        /// <param name="tabControltmp">加载到的TabControl</param>
        /// <param name="TheFolder">外部目录</param>
        public void ExternMode_Load(TabControl tabControltmp, String assType, DirectoryInfo TheFolder)
        {
            int a = 0, b = 0;
            ExternMode_Load(tabControltmp, assType, TheFolder, ref a, ref b);
        }
        /// <summary>
        /// 加载主程序目录下所有dll到TabControl
        /// </summary>
        /// <param name="tabControltmp">加载到的TabControl</param>
        public void ExternMode_Load(TabControl tabControltmp, String assType)
        {
            int a = 0, b = 0;
            ExternMode_Load(tabControltmp, assType, ref a, ref b);
        }

        /// <summary>
        /// 载入外部dll页面到Tab
        /// </summary>
        /// <param name="assName">外部DLL程序集名称</param>
        /// <param name="tabControltmp">TabControl控件</param>
        /// <returns></returns>
        public bool LoadPage(String assName, String assType, TabControl tabControltmp)
        {
            try
            {
                //                Assembly ass = Assembly.LoadFrom(assName);
                //#if DEBUG
                //                Console.WriteLine(ass.FullName);
                //#endif
                //                /*载入model*/

                //                Type type = ass.GetType(ass.GetName().Name + "." + assType);
                Type type = LoadType(assName, assType);
                /*载入ui*/
                Form tmpFrom = (Form)Activator.CreateInstance(type);
                tmpFrom.BackColor = Color.White;
                tmpFrom.Dock = DockStyle.Fill;
                tmpFrom.FormBorderStyle = FormBorderStyle.None; //隐藏子窗体边框（去除最小花，最大化，关闭等按钮）
                tmpFrom.TopLevel = false; //指示子窗体非顶级窗体
                /*生成子页面*/
                TabPage tmpPage = new TabPage();
                tmpPage.Controls.Add(tmpFrom);//将子窗体载入panel
                tmpPage.Text = tmpFrom.Text;
                /*子页面添加至主页*/
                tabControltmp.TabPages.Add(tmpPage);
                tmpFrom.Show();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool LoadPage(string assName, string assType, Form formTmp)
        {
            try
            {
                //                Assembly ass = Assembly.LoadFrom(assName);
                //#if DEBUG
                //                Console.WriteLine(ass.FullName);
                //#endif
                //                /*载入model*/

                //                Type type = ass.GetType(ass.GetName().Name + "." + assType);
                Type type = LoadType(assName, assType);
                /*载入ui*/
                Form tmpFrom = (Form)Activator.CreateInstance(type);
                tmpFrom.MdiParent = formTmp;
                tmpFrom.Show();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Type LoadType(string assName, string assType)
        {
            try
            {
                Assembly ass = Assembly.LoadFrom(assName);
#if DEBUG
                Console.WriteLine(ass.FullName);
#endif
                /*载入model*/
                Type type = ass.GetType(ass.GetName().Name + "." + assType);

                return type;
            }
            catch
            {
                return null;
            }
        }
    }
}
