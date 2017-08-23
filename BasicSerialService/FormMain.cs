using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InterfaceLink;

namespace BasicSerialService
{
    public partial class FormMain : Form, Interfaces

    {
        public FormMain()
        {
            InitializeComponent();
        }

        event EventHandler Interfaces.Even
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        void Interfaces.AppendBytes(byte[] buffPort)
        {
            throw new NotImplementedException();
        }

        void Interfaces.Recall_DataReceived(object sender, object e)
        {
            throw new NotImplementedException();
        }

        void Interfaces.Write(string text)
        {
            throw new NotImplementedException();
        }

        void Interfaces.Write(char[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        bool Interfaces.Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        void Interfaces.WriteLine(string text)
        {
            throw new NotImplementedException();
        }
    }
}
