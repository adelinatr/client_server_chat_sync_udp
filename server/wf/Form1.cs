using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace wf
{
    public partial class Form1 : Form
    {
        Socket socket;
        EndPoint remoteEP;
        List<EndPoint> clients;
        string log;
        int port;
        public Form1()
        {
            InitializeComponent();
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            port = 9000;
            IPEndPoint localEP = new IPEndPoint(ip, port);
            log = "returned port is : " + port.ToString();
            log += "server started";
            socket.Bind(localEP);
            remoteEP = new IPEndPoint(IPAddress.Any, 0);
            clients = new List<EndPoint>();
            Thread thread = new Thread(new ThreadStart(MainLoop));
            thread.Start();
            //trebuie chemata mainloop// creat alt thread     
            textBox1.Text += log;
            }

        void MainLoop()
        {
            while (true)
            {
                int noOfBytesReceived;
                Byte[] bytesReceived;
                noOfBytesReceived = 0;
                bytesReceived = new Byte[1024];
                noOfBytesReceived = socket.ReceiveFrom(bytesReceived, ref remoteEP);

                string message = Encoding.ASCII.GetString(bytesReceived, 0, noOfBytesReceived);

                int separatorIndex = message.IndexOf(':') + 1;
                string user = message.Substring(0, separatorIndex);
                string text = message.Substring(separatorIndex);

                switch (text)
                {
                    case "join":
                        clients.Add(remoteEP);
                        log += $"{user} joined";
                        break;
                    case "quit":
                        clients.RemoveAt(clients.IndexOf(remoteEP));
                        log += $"{user} quit";
                        break;
                    default:
                        log += $"{user}: {text}";
                        break;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
