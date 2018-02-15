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
		public ClientForm()
		{
			InitializeComponent();
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
				chatLog.ScrollBars = ScrollBars.Vertical;
			}
		}
	}
}
