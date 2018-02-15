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
		public ClientForm()
		{
			InitializeComponent();
			textBoxIPAdress.Text = "127.0.0.1";
			textBoxPort.Text = "9000";
        }

		private void buttonJoin_Click(object sender, EventArgs e)
		{
			try
			{
				UdpClient client = new UdpClient(textBoxIPAdress.Text, int.Parse(textBoxPort.Text));
            }
			catch (Exception ex)
			{
				chatLog.Text += $"{DateTime.Now.ToString("h:mm:ss tt")}: {ex.Message}\r\n";
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
