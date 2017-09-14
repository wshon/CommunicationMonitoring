using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SocketClient
{
    /// <summary>
    /// Socket Helper
    /// </summary>
    public class SocketHelper
    {
        private IPAddress ip;
        private IPEndPoint ex;
        private Socket socket;
        public delegate void DataReceivedDelegate(object sender, EventArgs e);
        public DataReceivedDelegate DataReceived;//= new GreetingDelegate();

        public SocketHelper(IPAddress ip, int port)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.ip = ip;
            this.ex = new IPEndPoint(this.ip, port);
        }

        /// <summary>
        /// Socket 进行连接
        /// </summary>
        /// <returns>连接失败OR成功</returns>
        public bool Socketlink()
        {
            try
            {
                socket.Connect(ex);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Socket 断开连接
        /// </summary>
        /// <returns>断开失败OR成功</returns>
        public bool SocketUnlink()
        {
            try
            {
                socket.Disconnect(false);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Socket 发送消息
        /// </summary>
        /// <param name="strmsg">消息</param>
        public void SendVarMessage(string strmsg)
        {
            try
            {
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(strmsg);
                this.socket.Send(msg);
            }
            catch (Exception ex)
            {
                this.socket.Close();
            }
        }

        /// <summary>
        /// Socket 消息回传
        /// </summary>
        /// <returns></returns>
        public void ReceiveMessage()
        {
            Thread SetProgress = new Thread(() => {
                while (true)
                {
                    //接收服务器信息
                    int bufLen = 0;
                    try
                    {
                        bufLen = socket.Available;
                        if (bufLen > 0)
                        {
                            byte[] data = new byte[bufLen];
                            socket.Receive(data, 0, bufLen, SocketFlags.None);
                            DataReceived(data, new EventArgs());
                            if (bufLen == 0)
                            {
                                continue;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Receive Error:" + ex.Message);
                        //return null;
                    }

                    //string clientcommand = System.Text.Encoding.ASCII.GetString(data).Substring(0, bufLen);

                    //lstClient是我的接收到的数据显示框
                    //lstClient.Items.Add(clientcommand);
                }
            });
            SetProgress.IsBackground = true;
            SetProgress.Start();
            //try
            //{
            //    byte[] msg = new byte[1048576];
            //    int recv = socket.Receive(msg);
            //    this.socket.Close();
            //    return System.Text.Encoding.UTF8.GetString(msg, 0, recv);
            //}
            //catch (Exception ex)
            //{
            //    this.socket.Close();
            //    return "ERROR";
            //}
        }
    }
}