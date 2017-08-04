using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerialMonitor
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        SerialLib.Serial SerialCon = new SerialLib.Serial();
        private void StartForm_Load(object sender, EventArgs e)
        {
            TitleTextBox.Text = "SerialPort" + ((UInt16)DateTime.Now.Ticks).ToString("D5");
            SerialCon.cB_SerialPortName = SerialNumberComboBox;
            SerialCon.cB_SerialBaudRate = BaudRateComboBox;
            SerialCon.cB_SerialParity = ParityComboBox;
            SerialCon.cB_SerialDataBits = DataBitsComboBox;
            SerialCon.cB_SerialStopBits = StopBitsComboBox;
            //SerialCon.Btn_Link = button1;
            //SerialCon.DataReceived += serialPort1_DataReceived;
            //SerialCon.SerialPortCon.DataReceived += serialPort1_DataReceived;
            SerialCon.SerialInit();
            /*
            if (BaudRateComboBox.Items.Count == 0)
            {
                //object[] baudRateList = 
                BaudRateComboBox.Items.AddRange(baudRateList);
                BaudRateComboBox.SelectedIndex = 5;
            }
            if (ParityComboBox.Items.Count == 0)
            {
                AddToComBox(ParityComboBox, typeof(Parity));
                ParityComboBox.SelectedIndex = 0;
            }
            if (DataBitsComboBox.Items.Count == 0)
            {
                object[] dataBitsList = new object[] { 8, 7, 6, 5 };
                DataBitsComboBox.Items.AddRange(dataBitsList);
                DataBitsComboBox.SelectedIndex = 0;
            }
            if (StopBitsComboBox.Items.Count == 0)
            {
                AddToComBox(StopBitsComboBox, typeof(StopBits));
                StopBitsComboBox.SelectedIndex = 1;
            }*/
        }

        

        private void addDeviceOKButton_Click(object sender, EventArgs e)
        {
            MainForm frmSerialFrom = new MainForm(TitleTextBox.Text, SerialCon.SerialPortCon);
            frmSerialFrom.MdiParent = this.ParentForm.Owner;
            frmSerialFrom.Show();
            TitleTextBox.Text = "SerialPort" + ((UInt16)DateTime.Now.Ticks).ToString("D5");
        }

        private void addDeviceCancelButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
