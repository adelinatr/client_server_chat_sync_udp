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

        const int cmPort = 9000;
        const string cmLocalIPAddress = "127.0.0.1";

        void InitServerSocket()
        {
            mPort = cmPort;
            mServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPAddress ip_address = IPAddress.Parse(cmLocalIPAddress);
            mLocalEP = new IPEndPoint(ip_address, mPort);
        }

        public Server()
        {
            InitializeComponent();

            InitServerSocket();

            textBox1.Text = ">> Server started\r\n";
            mServerSocket.Bind(mLocalEP);

            mRemoteEP = new IPEndPoint(IPAddress.Any, 0);
            mClients = new List<EndPoint>();

            Thread thread = new Thread(new ThreadStart(MainLoop));
            thread.Start();
        }

        void MainLoop()
        {
            while (true)
            {
                textBox1.Text += ">> Waiting\r\n";

                int noOfBytesReceived = 0;
                byte[] bytesReceived = new Byte[1024];

                noOfBytesReceived = mServerSocket.ReceiveFrom(bytesReceived, ref mRemoteEP);

                string message = Encoding.ASCII.GetString(bytesReceived, 0, noOfBytesReceived);

                int separatorIndex = message.IndexOf(':') + 1;
                string user = message.Substring(0, separatorIndex);
                string text = message.Substring(separatorIndex);

                switch (text)
                {
                    case "join":
                        mClients.Add(mRemoteEP);
                        textBox1.Text += $"{user} joined\r\n";
                        break;
                    case "quit":
                        mClients.RemoveAt(mClients.IndexOf(mRemoteEP));
                        textBox1.Text += $"{user} quit\r\n";
                        break;
                    default:
                        textBox1.Text += $"{user}: {text}\r\n";
                        break;
                }
            }
        }

        private void Form1_Closing(object sender, EventArgs e)
        {
            Dispose(true);
            Application.Exit();
            Process.GetCurrentProcess().Kill();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Server_Load(object sender, EventArgs e)
        {

        }
    }
}
