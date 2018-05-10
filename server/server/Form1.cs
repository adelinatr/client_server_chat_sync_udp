using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;

namespace server
{
    public partial class Server : Form
    {
        Socket mServerSocket;
        EndPoint mRemoteEP;
        List<EndPoint> mClients;
        IPEndPoint mLocalEP;
        int mPort;
        string log;
        const int cmPort = 9000;
        const string cmLocalIPAddress = "127.0.0.1";

        void InitServerSocket()
        {
            string ip_address_str;
            if (IPAddressBox.Text != "")
            {
                ip_address_str = IPAddressBox.Text;
            }
            else
            {
                ip_address_str = cmLocalIPAddress;
            }

            if (PortTextBox.Text != "")
            {
                mPort = int.Parse(PortTextBox.Text);
            }
            else
            {
                mPort = cmPort;
            }

            mServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPAddress ip_address = IPAddress.Parse(ip_address_str);
            mLocalEP = new IPEndPoint(ip_address, mPort);
        }

        public Server()
        {
            InitializeComponent();
            InitServerSocket();

            mClients = new List<EndPoint>();
            mRemoteEP = new IPEndPoint(IPAddress.Any, 0);
            mServerSocket.Bind(mLocalEP);

            Thread thread = new Thread(new ThreadStart(MainLoop));
            thread.IsBackground = true;
            thread.Start();

            UpdateClientList();

        }

		void FindRemoteClient()
		{

		}

        void UpdateLog()
        {
            if (textBox1.InvokeRequired)
            {
                textBox1.BeginInvoke((MethodInvoker)delegate () { textBox1.Text = log; });
            }
            else
            {
                textBox1.Text = log;
            }
        }


        void UpdateClientList()
        {
            /*if (listView1.InvokeRequired)
            {
                listView1.Clear();

                listView1.BeginInvoke((MethodInvoker)delegate () {
                    for (int i = 0; i < mClients.Count; i++)
                    {
                        ListViewItem lvi = new ListViewItem(mClients[i].ToString());
                        listView1.Items.Add(lvi);
                    }
                });
            }
            else
            {

                for (int i = 0; i < mClients.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem(mClients[i].ToString());
                    listView1.Items.Add(lvi);
                }
            }*/
        }

		private EndPoint FindRemoteClient(string user)
		{
			EndPoint endpoint = mClients[0];
			
			//todo search in mClients and return valid endpoint

			return endpoint;
		}

		void MainLoop()
        {

            while (true)
            {
                log += ">> Waiting\r\n";

                int noOfBytesReceived = 0;
                byte[] data = new byte[1024];
                
                noOfBytesReceived = mServerSocket.ReceiveFrom(data, ref mRemoteEP);

                string message = Encoding.ASCII.GetString(data, 0, noOfBytesReceived);

                int separatorIndexUser = message.IndexOf(':') + 1;
				int separatorIndexRcptUser = message.IndexOf('#') + 1;

				string user = message.Substring(0, separatorIndexUser);
				string rcptUser = message.Substring(separatorIndexUser, separatorIndexRcptUser);
				string text = message.Substring(separatorIndexUser);

                switch (text)
                {
                    case "join":
                        mClients.Add(mRemoteEP);
                        log += $"{user} joined\r\n";
                        break;
                    case "quit":
                        if (mClients.Count > 0)
                        {
                            mClients.RemoveAt(mClients.IndexOf(mRemoteEP));
                            log += $"{user} quit\r\n";
                        }
                        else
                        {
                            log += $"No clients connected\r\n";
                        }
                        break;
                    default:
                        string buff = Encoding.ASCII.GetString(data);
						//todo
						//Find Remote Client
						//EndPoint remoteRcptClient = FindRemoteClient(rcptUser);
                        mServerSocket.SendTo(Encoding.ASCII.GetBytes(buff), noOfBytesReceived, SocketFlags.None, mRemoteEP);

						log += $"{user}: {text}\r\n";
                        break;
                }

                UpdateLog();
                UpdateClientList();
            }
        }

        private void Form1_Closing(object sender, EventArgs e)
        {
            Dispose(true);
            Application.Exit();
            Process.GetCurrentProcess().Kill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log = ">> Server started\r\n";
            log += ">> Waiting\r\n";

            UpdateLog();
        }

    }
}
