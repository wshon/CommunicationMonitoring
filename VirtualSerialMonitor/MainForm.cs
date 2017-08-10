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
using System.IO.Ports;

namespace VirtualSerialMonitor
{
    public partial class MainForm : Form
    {
        private int SentBytes, RecvBytes;
        private Boolean Redirect;
        private Boolean Cts, Dsr, Dcd, Ri;
        AxVSPortAx axVSPortAx1;
        AxVSPortAx axVSPortAx2;
        public MainForm(string title, SerialPort userSerialPort1, SerialPort userSerialPort2)
        {
            InitializeComponent();
            this.Text = title;
            if (axVSPortAx1 == null) axVSPortAx1 = new AxVSPortAx();
            if (axVSPortAx2 == null) axVSPortAx2 = new AxVSPortAx();
            CreatePair(axVSPortAx3, userSerialPort1, axVSPortAx4, userSerialPort2);
        }

        private void CreatePair(AxVSPortAx VSPort1, SerialPort SPort1, AxVSPortAx VSPort2, SerialPort SPort2)
        {
            if (VSPort1.IsCreated != VSPort2.IsCreated)
            {
                MessageBox.Show("One port was create", "Warning", MessageBoxButtons.OK);
                this.ForeColor = Color.Orange;
                return;
            }
            if ((VSPort1.CreatePort(SPort1.PortName) || VSPort1.Attach(SPort1.PortName))
                && (VSPort2.CreatePort(SPort2.PortName) || VSPort2.Attach(SPort2.PortName)))
            {
                this.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Cannot create pair", "Warning", MessageBoxButtons.OK);
                VSPort1.Delete();
                VSPort2.Delete();
                this.ForeColor = Color.Orange;
            }
        }















        private void AddLog(string Str)
        {
            editLog.AppendText(DateTime.Now.ToString("T") + " - " + Str + "\r\n");
            editLog.Select(editLog.TextLength, 0);
        }

        private void AddLogData(Byte[] Buf, int Size)
        {
            for (int i = 0; i < Size; i++)
            {
                editTerminal.AppendText(Convert.ToString(Convert.ToChar(Buf[i])));
            }
        }

        private void EnableControl(Boolean Enable)
        {
            strPort1.Enabled = Enable;
            strPort2.Enabled = Enable;
            btnCts.Enabled = !Enable;
            btnDcd.Enabled = !Enable;
            btnDsr.Enabled = !Enable;
            btnRi.Enabled = !Enable;
            listBox1.Enabled = !Enable;
            tbMask.Enabled = !Enable;
            cmbAllow.Enabled = !Enable;
            btnAddMask.Enabled = !Enable;
            btnDelMask.Enabled = !Enable;
            lbSettings.Enabled = !Enable;
            label10.Enabled = !Enable;
            textSent.Enabled = !Enable;
            label16.Enabled = !Enable;
            textRecv.Enabled = !Enable;
            tbSettings.Enabled = !Enable;
            btnSettings.Enabled = !Enable;
            btnSettings.Enabled = !Enable;

            if (!Enable)
            {
                btnCts.Text = "Set CTS " + (Cts ? "OFF" : "ON");
                btnDsr.Text = "Set DSR " + (Dsr ? "OFF" : "ON");
                btnDcd.Text = "Set DCD " + (Dcd ? "OFF" : "ON");
                btnRi.Text = "Set RING " + (Ri ? "OFF" : "ON");
            }
            else
            {
                SentBytes = 0;
                RecvBytes = 0;
                textSent.Text = "0";
                textRecv.Text = "0";
            }
        }

        private void LoadAccessList()
        {
            string Name;
            bool allow;
            listBox1.Items.Clear();
            for (int a = 0; a < axVSPortAx1.AccessMaskCount; a++)
            {
                axVSPortAx1.GetAccessMask(a, out Name, out allow);
                listBox1.Items.Add(Name + (allow ? "(Allow)" : "(Deny)"));
            }
        }


        private void Form1_Load(object sender, System.EventArgs e)
        {
            Cts = true;
            Dsr = true;
            Dcd = true;
            Ri = false;
            SentBytes = 0;
            RecvBytes = 0;
            AddLog("Port1 activity log...\r\n");
            cmbAllow.SelectedIndex = 1;
        }

        private void btnCreatePort_Click(object sender, System.EventArgs e)
        {
            if (axVSPortAx1.IsCreated)
            {
                if (axVSPortAx1.Delete())
                {
                    btnCreatePair.Enabled = true;
                    btnResetBus.Enabled = true;
                    btnCreatePort.Text = "Create port";
                    EnableControl(true);
                    btnSendFile.Enabled = false;
                    AddLog("Delete port " + strPort1.Text);
                }
                else
                {
                    MessageBox.Show("Port cannot be deleted: the ports is open.", "Warning", MessageBoxButtons.OK);
                }
            }
            else
            {
                //String strUser = checkUser.Checked ? axVSPortAx1.IdUserSession : "";
                if (axVSPortAx1.CreatePort(strPort1.Text) || axVSPortAx1.Attach(strPort1.Text))
                {
                    chkBreak.Checked = false;
                    btnResetBus.Enabled = false;
                    axVSPortAx1.SetStrictBaudrate(chkStrict.Checked);
                    btnCreatePair.Enabled = false;
                    btnCreatePort.Text = "Delete port";
                    EnableControl(false);
                    btnSendFile.Enabled = true;
                    AddLog("Create port " + strPort1.Text);
                    LoadAccessList();
                    axVSPortAx1.SetWiring(0x20, 0x10, 0, 0);
                    BuildPortSettings();
                }
                else
                {
                    MessageBox.Show("Cannot be created port", "Warning", MessageBoxButtons.OK);
                }
            }
        }

        private void btnCreatePair_Click(object sender, System.EventArgs e)
        {
            if (axVSPortAx1.IsCreated != axVSPortAx2.IsCreated)
            {
                MessageBox.Show("One port was create", "Warning", MessageBoxButtons.OK);
                return;
            }

            if (axVSPortAx1.IsCreated)
            {
                if (axVSPortAx1.Delete() && axVSPortAx2.Delete())
                {
                    btnCreatePair.Text = "Create pair";
                    btnResetBus.Enabled = true;
                    btnCreatePort.Enabled = true;
                    EnableControl(true);
                    Redirect = false;
                    AddLog("Delete pair " + strPort1.Text + "<->" + strPort2.Text);
                }
                else
                {
                    MessageBox.Show("Pair cannot be deleted: one of the ports is open.", "Warning", MessageBoxButtons.OK);
                    axVSPortAx1.CreatePort(strPort1.Text);
                    axVSPortAx2.CreatePort(strPort2.Text);
                }
            }
            else
            {
                //String strUser = checkUser.Checked ? axVSPortAx1.IdUserSession : "";

                if ((axVSPortAx1.CreatePort(strPort1.Text) || axVSPortAx1.Attach(strPort1.Text))
                    && (axVSPortAx2.CreatePort(strPort2.Text) || axVSPortAx2.Attach(strPort2.Text)))
                {
                    btnResetBus.Enabled = false;
                    btnCreatePort.Enabled = false;
                    btnCreatePair.Text = "Delete pair";
                    EnableControl(false);
                    Redirect = true;
                    AddLog("Create pair " + strPort1.Text + ("<->") + strPort2.Text);
                    LoadAccessList();
                    axVSPortAx1.SetWiring(0x20, 0x10, 0, 0);
                    axVSPortAx2.SetWiring(0x20, 0x10, 0, 0);
                    BuildPortSettings();
                }
                else
                {
                    MessageBox.Show("Cannot create pair", "Warning", MessageBoxButtons.OK);
                    axVSPortAx1.Delete();
                    axVSPortAx2.Delete();
                }
            }
        }

        private void btnResetBus_Click(object sender, System.EventArgs e)
        {
            if (!axVSPortAx1.ResetBus())
            {
                AddLog("Unable to reset bus. Possibly one of the ports is created at the moment.");
            }
            else
            {
                AddLog("Reset bus");
            }
        }

        private void btnSendFile_Click(object sender, System.EventArgs e)
        {
            int fRead;
            int SizeBuf;
            byte[] Buff = new byte[Convert.ToInt32(textLen.Text)];
            byte[] BuffPort;
            fRead = Convert.ToInt32(textLen.Text);
            SizeBuf = fRead;

            openFileDialog1.Filter = "All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream file = new System.IO.FileStream(openFileDialog1.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                while (fRead == SizeBuf)
                {
                    fRead = file.Read(Buff, 0, SizeBuf);
                    BuffPort = new byte[fRead];
                    Array.Copy(Buff, BuffPort, fRead);
                    fRead = axVSPortAx1.WriteArray(BuffPort);
                    SentBytes = SentBytes + fRead;
                    textSent.Text = Convert.ToString(SentBytes);
                }
            }
        }

        private void btnCts_Click(object sender, System.EventArgs e)
        {
            Cts = !Cts;
            axVSPortAx1.SetCTS(Cts);
            EnableControl(false);
        }

        private void btnDsr_Click(object sender, System.EventArgs e)
        {
            Dsr = !Dsr;
            axVSPortAx1.SetDSR(Dsr);
            EnableControl(false);
        }

        private void btnDcd_Click(object sender, System.EventArgs e)
        {
            Dcd = !Dcd;
            axVSPortAx1.SetDCD(Dcd);
            EnableControl(false);
        }

        private void btnRi_Click(object sender, System.EventArgs e)
        {
            Ri = !Ri;
            axVSPortAx1.SetRING(Ri);
            EnableControl(false);
        }

        private void chkStrict_CheckedChanged(object sender, System.EventArgs e)
        {
            axVSPortAx1.SetStrictBaudrate(chkStrict.Checked);
            axVSPortAx2.SetStrictBaudrate(chkStrict.Checked);
        }

        private void chkBreak_CheckedChanged(object sender, System.EventArgs e)
        {
            axVSPortAx1.SetBreak(chkBreak.Checked);
            axVSPortAx2.SetBreak(chkBreak.Checked);
        }

        private void axVSPortAx1_OnBaudRate(object sender, AxVSPortLib._IVSPortAxEvents_OnBaudRateEvent e)
        {
            AddLog("BaudRate changed to " + Convert.ToString(e.baudrate));
            BuildPortSettings();
        }

        private void axVSPortAx1_OnDTR(object sender, AxVSPortLib._IVSPortAxEvents_OnDTREvent e)
        {
            AddLog("DTR changed to " + (e.dtr ? "ON" : "OFF"));
        }

        private void axVSPortAx1_OnEvent(object sender, AxVSPortLib._IVSPortAxEvents_OnEventEvent e)
        {
            //AddLog("Event mask: " + Convert.ToString(e.evtMask));
        }

        private void axVSPortAx1_OnHandflow(object sender, AxVSPortLib._IVSPortAxEvents_OnHandflowEvent e)
        {
            System.Text.StringBuilder str = new System.Text.StringBuilder();
            str.AppendFormat("Flow control changed to CHSh:0x{0:X}, FR:0x{1:X}, XOnL:0x{2:X}, XOffL:0x{3:X}",
                e.controlHandShake, e.flowReplace, e.xOnLimit, e.xOffLimit);
            AddLog(str.ToString());
            BuildPortSettings();
        }

        private void axVSPortAx1_OnLineControl(object sender, AxVSPortLib._IVSPortAxEvents_OnLineControlEvent e)
        {
            System.Text.StringBuilder str = new System.Text.StringBuilder();
            str.AppendFormat("Line control changed to StpBts:0x{0:X}, Prty:0x{1:X}, WrdLen:0x{2:x}",
                e.stopBits, e.parity, e.wordLength);
            AddLog(str.ToString());
            BuildPortSettings();
        }

        private void axVSPortAx1_OnOpenClose(object sender, AxVSPortLib._IVSPortAxEvents_OnOpenCloseEvent e)
        {
            AddLog("---------------------------------------");
            AddLog("Virtual Serial Port " + strPort1.Text + " " + (e.opened ? "opened" : "closed"));
            AddLog("---------------------------------------");
            if (e.opened && axVSPortAx1.PortOpenAppPath.Length != 0)
            {
                AddLog("Application: " + axVSPortAx1.PortOpenAppPath);
            }
        }

        private void axVSPortAx1_OnRTS(object sender, AxVSPortLib._IVSPortAxEvents_OnRTSEvent e)
        {
            AddLog("RTS changed to " + (e.rts ? "ON" : "OFF"));
        }

        private void axVSPortAx1_OnRxChar(object sender, AxVSPortLib._IVSPortAxEvents_OnRxCharEvent e)
        {
            byte[] Buff;
            int ReceivedCnt;


            Buff = axVSPortAx1.ReadArray(e.count) as byte[];
            ReceivedCnt = Buff.Length;
            if (ReceivedCnt != 0)
            {
                AddLog(Convert.ToString(ReceivedCnt) + " byte(s) read ");
                AddLogData(Buff, ReceivedCnt);
                RecvBytes = RecvBytes + ReceivedCnt;
                textRecv.Text = Convert.ToString(RecvBytes);

                if (Redirect)
                {
                    axVSPortAx2.WriteArray(Buff);
                }
            }
        }

        private void axVSPortAx1_OnSpecialChars(object sender, AxVSPortLib._IVSPortAxEvents_OnSpecialCharsEvent e)
        {
            System.Text.StringBuilder str = new System.Text.StringBuilder();
            str.AppendFormat("Special chars changed to EOF:0x{0:X}, ERR:0x{1:X}, BRK:0x{2:X}, EVNT:0x{3:X}, XON:0x{4:X}, XOFF:0x{5:X}",
                e.eofChar, e.errorChar, e.breakChar, e.eventChar, e.xOnChar, e.xOffChar);
            AddLog(str.ToString());
        }

        private void axVSPortAx1_OnTimeouts(object sender, AxVSPortLib._IVSPortAxEvents_OnTimeoutsEvent e)
        {
            System.Text.StringBuilder str = new System.Text.StringBuilder();
            str.AppendFormat("Timeouts changed to RIT:0x{0:X}, RTTM:0x{1:X}, RTTC:0x{2:X}, WTTM:0x{3:X}, WTTC:0x{4:X}",
                e.readIntervalTimeout, e.readTotalTimeoutMultiplier,
                e.readTotalTimeoutMultiplier, e.writeTotalTimeoutMultiplier,
                e.writeTotalTimeoutConstant);
            AddLog(str.ToString());
        }

        private void axVSPortAx2_OnRxChar(object sender, AxVSPortLib._IVSPortAxEvents_OnRxCharEvent e)
        {
            byte[] Buff;
            Buff = axVSPortAx2.ReadArray(e.count) as byte[];
            SentBytes = SentBytes + axVSPortAx1.WriteArray(Buff);
            textSent.Text = Convert.ToString(SentBytes);
        }

        private void editTerminal_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (axVSPortAx1.IsCreated)
            {
                byte[] Key = new byte[1];
                Key[0] = Convert.ToByte(e.KeyChar);
                SentBytes += axVSPortAx1.WriteArray(Key);
                textSent.Text = Convert.ToString(SentBytes);
                AddLog("1 byte(s) sent " + Convert.ToChar(Key[0]));
            }
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (axVSPortAx1.IsOpened || axVSPortAx2.IsOpened)
            {
                if (MessageBox.Show("Virtual Serial Port is still used by other application\r\nDo you want to exit anyway ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
            axVSPortAx1.Delete();
            axVSPortAx2.Delete();
        }

        private void axVSPortAx1_OnBreak(object sender, AxVSPortLib._IVSPortAxEvents_OnBreakEvent e)
        {
            AddLog("Break is " + (e.bBreak ? "ON" : "OFF"));
        }

        private void axVSPortAx1_OnRING(object sender, AxVSPortLib._IVSPortAxEvents_OnRINGEvent e)
        {
            AddLog("RING changed to " + (e.ring ? "ON" : "OFF"));
        }

        private void checkUser_CheckedChanged(object sender, EventArgs e)
        {

        }
        

        private void btnAddMask_Click(object sender, System.EventArgs e)
        {
            axVSPortAx1.AppendAccessMask(tbMask.Text, Convert.ToBoolean(cmbAllow.SelectedIndex));
            LoadAccessList();
        }

        private void btnDelMask_Click(object sender, System.EventArgs e)
        {
            axVSPortAx1.DeleteAccessMask(listBox1.SelectedIndex);
            LoadAccessList();
        }

        private void BuildPortSettings()
        {
            string str;

            if (axVSPortAx1.IsOpened)
            {
                // Baudrate
                str = "Current port settings: " + Convert.ToString(axVSPortAx1.Baudrate);
                // Parity
                switch (axVSPortAx1.Parity)
                {
                    case 0:
                        str = str + ",N";   // NOPARITY
                        break;
                    case 1:
                        str = str + ",O";     // ODDPARITY
                        break;
                    case 2:
                        str = str + ",E";      // EVENPARITY
                        break;
                    case 3:
                        str = str + ",M";      // MARKPARITY
                        break;
                    case 4:
                        str = str + ",S";      // SPACEPARITY
                        break;
                }
                // Databits
                str = str + "," + axVSPortAx1.Databits;
                // stopbits
                str = str + "," + ((axVSPortAx1.StopBits == 0) ? "1" : "2");
                // Flow control
                long ControlHandShake = axVSPortAx1.ControlHandShake;
                long FlowReplace = axVSPortAx1.FlowReplace;

                if (((ControlHandShake & 0x01) == 0x01) && ((FlowReplace & 0x43) == 0x43))
                {
                    str = str + ",X";
                }
                else if ((((ControlHandShake & (0x10 | 0x08 | 0x02)) == (0x10 | 0x08 | 0x02)) && ((FlowReplace & 0x80) == (0x80)) && !((FlowReplace & (0x01 | 0x02)) == 0x03)))
                {
                    str = str + ",P";
                }
                lbSettings.Text = str;
            }
            else
            {
                lbSettings.Text = "Current port settings: closed";
            }
        }

        private void btnSettings_Click(object sender, System.EventArgs e)
        {
            if (tbSettings.Text.Length == 0)
            {
                return;
            }

            tbSettings.Text.ToUpper();
            // baudrate
            int PosEnd = tbSettings.Text.IndexOf(",", 0);
            string param = tbSettings.Text.Substring(0, PosEnd);
            axVSPortAx1.Baudrate = Convert.ToInt32(param);

            // prity
            int PosBegin = PosEnd + 1;
            PosEnd = tbSettings.Text.IndexOf(",", PosBegin);
            param = tbSettings.Text.Substring(PosBegin, PosEnd - PosBegin);

            switch (param[0])
            {
                case 'N': //NONEPARITY
                    axVSPortAx1.Parity = 0;
                    break;
                case 'O': //ODDPARITY
                    axVSPortAx1.Parity = 1;
                    break;
                case 'E': //EVENPARITY
                    axVSPortAx1.Parity = 2;
                    break;
                case 'M': //MARKPARITY
                    axVSPortAx1.Parity = 3;
                    break;
                case 'S': //SPACEPARITY
                    axVSPortAx1.Parity = 4;
                    break;
            }

            // databits
            PosBegin = PosEnd + 1;
            PosEnd = tbSettings.Text.IndexOf(",", PosBegin);
            param = tbSettings.Text.Substring(PosBegin, PosEnd - PosBegin);

            axVSPortAx1.Databits = Convert.ToInt32(param);

            // stop bits
            PosBegin = PosEnd + 1;
            PosEnd = tbSettings.Text.IndexOf(",", PosBegin);

            if (PosEnd != -1)
            {
                param = tbSettings.Text.Substring(PosBegin, PosEnd - PosBegin);
                axVSPortAx1.StopBits = (param[0] == '1' ? 0 : 2);

                // Flow control
                PosBegin = PosEnd + 1;
                param = tbSettings.Text.Substring(PosBegin);
                //param = Mid(tbSettings.Text, PosBegin);

                switch (param[0])
                {
                    case 'P':
                        axVSPortAx1.ControlHandShake = 0x10 | 0x08 | 0x02;
                        axVSPortAx1.FlowReplace = 0x80;
                        break;

                    case 'X':
                        axVSPortAx1.ControlHandShake = 0x01;
                        axVSPortAx1.FlowReplace = 0x01 | 0x02 | 0x40;
                        break;
                    default:
                        axVSPortAx1.ControlHandShake = 0x01;
                        axVSPortAx1.FlowReplace = 0x040;
                        break;
                }

            }
            else
            {
                param = tbSettings.Text.Substring(PosBegin);
                axVSPortAx1.StopBits = (param[0] == '1' ? 0 : 2);
                axVSPortAx1.ControlHandShake = 0x01;
                axVSPortAx1.FlowReplace = 0x40;
            }

            BuildPortSettings();
        }
    }
}
