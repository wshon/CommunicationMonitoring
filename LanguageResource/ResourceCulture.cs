using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LanguageResource
{
    public class ResourceCulture
    {
        /// <summary>
        /// Set current culture by name
        /// </summary>
        /// <param name="name">name</param>
        public static void SetCurrentCulture(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "zh-CN";
            }

            Thread.CurrentThread.CurrentCulture = new CultureInfo(name);
        }

        /// <summary>
        ///  Get string by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool GetString(string id, ref string strCurLanguage,Assembly userAssembly)
        {
            try
            {
                ResourceManager rm = new ResourceManager(userAssembly.GetName().Name + ".Resource", userAssembly);
                CultureInfo ci = Thread.CurrentThread.CurrentCulture;
                strCurLanguage = rm.GetString(id, ci);
                Debug.WriteLine("The ID:\"" + id + "\" Value:\"" + strCurLanguage + "\"\r\n");
                return true;
            }
            catch (Exception e)
            {
                //strCurLanguage = "No id:" + id + ", please add.";
                Debug.WriteLine(e.Message);
                Debug.WriteLine("The ID:\"" + id + "\" Value:\"" + strCurLanguage + "\"\r\n");
                return false;
            }

        }

        public static void SetResourceCulture(ToolStripItemCollection items, Assembly userAssembly)
        {
            //遍历所有控件
            foreach (object item in items)
            {
                try
                {
                    string strTextTmp = ((ToolStripMenuItem)item).Text;
                    if (ResourceCulture.GetString(((ToolStripMenuItem)item).Name + "_Text", ref strTextTmp, userAssembly))
                        ((ToolStripMenuItem)item).Text = strTextTmp;
                    if ((((ToolStripMenuItem)item).DropDownItems.Count != 0))
                    {
                        SetResourceCulture(((ToolStripMenuItem)item).DropDownItems, userAssembly);
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }
            }
        }

        public static void SetResourceCulture(Control.ControlCollection items, Assembly userAssembly)
        {
            //遍历所有控件
            foreach (Control item in items)
            {
                string strTextTmp = item.Text;
                if (ResourceCulture.GetString(item.Name + "_Text", ref strTextTmp, userAssembly))
                    item.Text = strTextTmp;
                if ((item.Controls.Count != 0))
                {
                    SetResourceCulture(item.Controls, userAssembly);
                }
            }
        }

    }
}
