using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace RegisterVSPort
{
    class Register
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "regsvr32";
            p.StartInfo.Verb = "runas";
            p.StartInfo.Arguments = "\"" + System.AppDomain.CurrentDomain.BaseDirectory + "VSPort.dll\" /i:\"Jinan USR IOT Co., Ltd.#0000K5-ATQURC-ZAR826-7RP5JJ-W3RX79-V7TD62-9AE4C4-AA1397-43BE51-60FDA3-55F088-A46793\"";
            Console.WriteLine("regsvr32 \"" + System.AppDomain.CurrentDomain.BaseDirectory + "VSPort.dll\"\r\n");
            p.Start();
            p.WaitForExit();
            p.StartInfo.Arguments = "\"" + System.AppDomain.CurrentDomain.BaseDirectory + "VSPort64.dll\" /i:\"Jinan USR IOT Co., Ltd.#0000K5-ATQURC-ZAR826-7RP5JJ-W3RX79-V7TD62-9AE4C4-AA1397-43BE51-60FDA3-55F088-A46793\"";
            Console.WriteLine("regsvr32 \"" + System.AppDomain.CurrentDomain.BaseDirectory + "VSPort64.dll\"\r\n");
            p.Start();
            p.WaitForExit();
            p.Close();
            p.Dispose();
        }
    }
}
