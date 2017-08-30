using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace GeneralSerialService
{
    class Mamage
    {
        public void install()
        {
            var path = Process.GetCurrentProcess().MainModule.FileName + " s";
            Process.Start("sc", "create SSerialSvc binpath=\"" + ".\\" + path + "\" displayName=\"Skogen Serial Service\" start=auto");
            Console.WriteLine("安装成功");
            Console.Read();
        }
        public void uninstall()
        {
            Process.Start("sc", "delete SSerialSvc");
            Console.WriteLine("卸载成功");
            Console.Read();
        }
    }
}
