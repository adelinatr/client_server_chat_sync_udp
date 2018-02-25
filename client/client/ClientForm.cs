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

namespace ClientChatWF
{
	public partial class ClientForm : Form
	{
		int oldHeight;
		int oldWidth;
		Socket client;
		EndPoint remoteEp;
		bool isConnected = false;

		public ClientForm()
		{
			InitializeComponent();
			textBoxIPAdress.Text = "127.0.0.1";
			textBoxPort.Text = "9000";
            this.Text = "Disconnected";
        }
        
		private void buttonJoin_Click(object sender, EventArgs e)
		{
			if (!isConnected)
			{
                		try
				{
					if (textBoxUsername.Text.Length != 0)
					{
						client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);					
						IPAddress ip= IPAddress.Parse(textBoxIPAdress.Text);
						remoteEp = new IPEndPoint(ip, int.Parse(textBoxPort.Text));
						byte[] bt = Encoding.ASCII.GetBytes($"{textBoxUsername.Text}:join");
                        			client.SendTo(bt, remoteEp);
						isConnected = true;
						statusLabel.Text = "Connected";
                    
					}
                    if (isConnected)
                    {
                        this.Text = "Connected to server on port " + $"{textBoxPort.Text}";
                    }
                }
				catch (Exception ex)
				{
					chatLog.Text += $"{ex.Message}\r\n";
				}
			}
		}

		private void buttonSend_Click(object sender, EventArgs e)
		{
			if (isConnected)
			{
				client.SendTo(Encoding.ASCII.GetBytes(textBoxMessage.Text), remoteEp);
				chatLog.Text += $"{textBoxUsername.Text}:{ textBoxMessage.Text}\r\n";
				textBoxMessage.Text = "";
			}
		}
		private void buttonQuit_Click(object sender, EventArgs e)
		{
			if (isConnected)
			{
				client.SendTo(Encoding.ASCII.GetBytes($"{textBoxUsername.Text}:quit"), remoteEp);
				isConnected = false;
				statusLabel.Text = "Disconnected";
                this.Text = "Disconnected";
            }
		}

		private void ClientForm_ResizeBegin(object sender, EventArgs e)
		{
			oldHeight = this.Height;
			oldWidth = this.Width;
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

        private void T_Click(object sender, EventArgs e)
        {

           
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            T.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

		private void button1_Click(object sender, EventArgs e)
		{
			//String Data = Encoding.ASCII.GetString(data);
			byte[] time = Encoding.ASCII.GetBytes($"{textBoxUsername.Text}:gettime");
			client.SendTo(time, time.Length, SocketFlags.None, remoteEp);
		}

		private void label4_Click(object sender, EventArgs e)
		{
			byte[] received_time = new byte[1024];
			client.ReceiveFrom(received_time, ref remoteEp);
			String time = System.Text.Encoding.UTF8.GetString(received_time);
			label4.Text = time;
		}
	}
}
