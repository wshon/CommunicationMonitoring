using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AxVSPortLib;
using VSPortLib;

namespace VirtualSerialMonitor
{
    public partial class MainForm : Form
    {

        public MainForm(string title, string userSerialPort)
        {
            InitializeComponent();
            this.Text = title;
            CreatPort(userSerialPort);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeletaPort();
        }


        public enum Error
        {
            NoError,
            Error,
            IsNotCreat,
            PortCreatError,
            PortDeleteError,

            IsNotPair,
            PairCreatError,
            PortOneIsCreated,
            PortTwoIsCreated,
        };

        private VSPortAx axVSPortAx = new VSPortAx();
        private string port;

        public Error CreatPort(string strPort1)
        {
            port = strPort1;
            if (axVSPortAx.CreatePort(strPort1) || axVSPortAx.Attach(strPort1))
            {
                axVSPortAx.SetBreak(true);
                axVSPortAx.SetStrictBaudrate(true);
                axVSPortAx.SetWiring(0x20, 0x10, 0, 0);
                return Error.NoError;
            }
            else
            {
                return Error.Error;
            }
        }

        public Error DeletaPort()
        {
            if (axVSPortAx.IsCreated)
            {
                if (axVSPortAx.Delete())
                {
                    return Error.NoError;
                }
                else
                {
                    return Error.Error;
                }
            }
            else
            {
                return Error.IsNotCreat;
            }
        }

        public Error ResetBus()
        {
            if (!axVSPortAx.ResetBus())
            {
                return Error.NoError;
            }
            else
            {
                return Error.Error;
            }
        }
    }
}
