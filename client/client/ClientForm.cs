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
		IPEndPoint remoteEp;
		bool isConnected = false;

		public ClientForm()
		{
			InitializeComponent();
			textBoxIPAdress.Text = "127.0.0.1";
			textBoxPort.Text = "9000";
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
						remoteEp = new IPEndPoint(IPAddress.Parse(textBoxIPAdress.Text), int.Parse(textBoxPort.Text));
						client.SendTo(Encoding.ASCII.GetBytes($"{textBoxUsername.Text}:join"), remoteEp);
						isConnected = true;
						statusLabel.Text = "Connected";
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
	}
}
