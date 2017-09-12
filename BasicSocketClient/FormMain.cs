using InterfaceLink;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BasicSocketClient
{
    public partial class FormMain : Form, Interfaces
    {
        public FormMain()
        {
            InitializeComponent();
        }
        #region 接口
        public event EventHandler DataReceived;

        public void EventTest()
        {
            //throw new NotImplementedException();
        }

        public bool Write(string text)
        {
            throw new NotImplementedException();
        }

        public bool Write(char[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public bool Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public bool WriteLine(string text)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
