using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ClientChatWF
{
    public partial class ClientForm : Form
    {
        int oldHeight;
        int oldWidth;
        Socket client;
        EndPoint remoteEp;
        bool isConnected = false;
        byte[] data;
        int recv;
        string mNewMessage;
        bool receivedBack;
        int Count = 0;
        bool send = false;
		string selected_user;

        public ClientForm()
        {
            InitializeComponent();
            textBoxIPAdress.Text = "127.0.0.1";
            textBoxPort.Text = "9000";
            Text = "Client";
            mNewMessage = "";
            receivedBack = false;
        }

        private void buttonJoin_Click(object sender, EventArgs e)
        {
            Count++;
            if (!isConnected)
            {
                try
                {
                    if (textBoxUsername.Text.Length != 0)
                    {
                        client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                        IPAddress ip = IPAddress.Parse(textBoxIPAdress.Text);
                        remoteEp = new IPEndPoint(ip, int.Parse(textBoxPort.Text));
                        byte[] bt = Encoding.ASCII.GetBytes($"{textBoxUsername.Text}:join");
                        client.SendTo(bt, remoteEp);
                        isConnected = true;

                        Thread thread_receive = new Thread(new ThreadStart(Receive));
                        thread_receive.IsBackground = true;
                        thread_receive.Start();
                    }
                    else
                    {
                        MessageBox.Show("Username cannot be empty!");
                    }
                }
                catch (Exception ex)
                {
                    chatLog.Text += $"{ex.Message}\r\n";
                }
            }

            //window title
            if (isConnected && receivedBack)
            {
                Text = "Client connected to server on port " + $"{textBoxPort.Text}";
                statusLabel.Text = "Connected";
            }

            if (!receivedBack && Count>1 && send)
            {
                MessageBox.Show("Server not running!");
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("User must be connected!");
                return;
            }

            mNewMessage = textBoxMessage.Text;
            Thread thread = new Thread(new ThreadStart(Send));
            thread.IsBackground = true;
            thread.Start();
			selected_user = "client1";
            chatLog.Text += $"{textBoxUsername.Text}:{selected_user}#{textBoxMessage.Text}\r\n";
            textBoxMessage.Text = "";
        }

        private void Send()
        {
            byte[] data = Encoding.ASCII.GetBytes($"{textBoxUsername.Text}:{selected_user}#{mNewMessage}");
            if (data != null)
            {
                client.SendTo(data, remoteEp);
            }
            send = true;
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                client.SendTo(Encoding.ASCII.GetBytes($"{textBoxUsername.Text}:quit"), remoteEp);
                isConnected = false;
                if (receivedBack)
                {
                    statusLabel.Text = "Disconnected";
                    Text = "Client disconnected";
                }
                else if (send)
                {
                    MessageBox.Show("Server not running!");
                }
            }
        }

        private void ClientForm_ResizeBegin(object sender, EventArgs e)
        {
            oldHeight = Height;
            oldWidth = Width;
        }

        private void ClientForm_ResizeEnd(object sender, EventArgs e)
        {
            int heightDiff = oldHeight - this.Height;
            int widthDiff = oldWidth - this.Width;

            chatLog.Width -= widthDiff;
            chatLog.Height -= heightDiff;

            textBoxMessage.Top -= heightDiff;
            textBoxMessage.Width -= widthDiff;

            buttonSend.Top -= heightDiff;
            buttonSend.Left -= widthDiff;

            statusLabel.Width -= widthDiff;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }


        public void Receive()
        {
            if (data != null)
            {
                recv = client.ReceiveFrom(data, ref remoteEp);
                chatLog.Text += $"{textBoxUsername.Text}: {mNewMessage}\r\n";
                receivedBack = true;
            }
        }

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
		/*private void button1_Click(object sender, EventArgs e)
		{
			//String Data = Encoding.ASCII.GetString(data);
			byte[] time = Encoding.ASCII.GetBytes($"{textBoxUsername.Text}:gettime");
			client.SendTo(time, time.Length, SocketFlags.None, remoteEp);
		}

		private void _Click(object sender, EventArgs e)
		{
			byte[] received_time = new byte[1024];
			client.ReceiveFrom(received_time, ref remoteEp);
			String time = System.Text.Encoding.UTF8.GetString(received_time);
			label4.Text = time;
		}*/
}

