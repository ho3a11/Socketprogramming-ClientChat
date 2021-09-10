using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client_Chat
{
    public partial class Form1 : Form
    {
        Socket SClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }
        public void getMsg()
        {

            try
            {
                while (true)
                {
                    byte[] b = new byte[1024];
                    int R = SClient.Receive(b);
                    if (R > 0)
                    {
                        ListMessages.Items.Add("Server :" + Encoding.Unicode.GetString(b, 0, R));
                    }
                }
            }
            catch
            {
                ;
            }
        }
            private void btnConnect_Click(object sender, EventArgs e)
        {
            IPEndPoint IpServe = new IPEndPoint(IPAddress.Parse(txtIp.Text), int.Parse(txtPort.Text));
            try
            {
                SClient.Connect(IpServe);
                MessageBox.Show("Connect ");

                Thread tr = new Thread(new ThreadStart(getMsg));
                tr.Start();
            }
            catch
            {
                MessageBox.Show("Server  not Start");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (SClient != null)
            {
                SClient.Shutdown(SocketShutdown.Both);
                //Environment.Exit(Environment.ExitCode);
               
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] barray = new byte[1024];
            barray = Encoding.Unicode.GetBytes(txtMessage.Text);
            SClient.Send(barray);
            ListMessages.Items.Add("Client: " + txtMessage.Text);

            txtMessage.Clear();
        }
    }
}
