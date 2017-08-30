using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace GeneralSerialService
{
        static class Program
        {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        //static void Main()
        //{
        //    ServiceBase[] ServicesToRun;
        //    ServicesToRun = new ServiceBase[]
        //    {
        //        new Service()
        //    };
        //    ServiceBase.Run(ServicesToRun);
        //}
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                new Service()
                };
                ServiceBase.Run(ServicesToRun);
            }
            else if (args.Length == 1)
            {
                //取当前可执行文件路径，加上"s"参数，证明是从windows服务启动该程序
                var path = Process.GetCurrentProcess().MainModule.FileName + " s";
                if (args[0] == "install")
                {
                    Process.Start("sc", "create SSerialSvc binpath=\"" + ".\\" + path + "\" displayName=\"Skogen Serial Service\" start=auto");
                    Console.WriteLine("安装成功");
                    Console.Read();
                }
                else if (args[0] == "uninstall")
                {
                    Process.Start("sc", "delete SSerialSvc");
                    Console.WriteLine("卸载成功");
                    Console.Read();
                }
                else
                {
                    Debug.Write("Ex:");
                    Debug.Write("   " + path + " install");
                    Debug.Write("   " + path + " uninstall");
                }
            }
        }
        //Console.WriteLine("这是Windows应用程序");
        //Console.WriteLine("请选择，[1]安装服务 [2]卸载服务 [3]退出");
        //var rs = int.Parse(Console.ReadLine());
        //switch (rs)
        //{
        //    case 1:
        //        //取当前可执行文件路径，加上"s"参数，证明是从windows服务启动该程序
        //        var path = Process.GetCurrentProcess().MainModule.FileName + " s";
        //        Process.Start("sc", "create myserver binpath= \"" + path + "\" displayName= SerialService start= auto");
        //        Console.WriteLine("安装成功");
        //        Console.Read();
        //        break;
        //    case 2:
        //        Process.Start("sc", "delete SerialService");
        //        Console.WriteLine("卸载成功");
        //        Console.Read();
        //        break;
        //    case 3: break;
        //}
    }
}
