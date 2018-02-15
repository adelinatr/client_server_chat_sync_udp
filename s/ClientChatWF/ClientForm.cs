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
        Socket client;
        IPEndPoint remoteEp;
		public ClientForm()
		{
			InitializeComponent();
		}

		private void buttonJoin_Click(object sender, EventArgs e)
		{

            client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            remoteEp = new IPEndPoint(IPAddress.Parse(textBoxIPAdress.Text), int.Parse(textBoxPort.Text));
            client.SendTo(Encoding.ASCII.GetBytes("join"), remoteEp);
            
          
		}

        private void textBoxIPAdress_TextChanged(object sender, EventArgs e)
        {
            if(textBoxIPAdress.Text!="127.0.0.1")
            {
                return;
            }
            string ip;
            ip = textBoxIPAdress.Text;

            IPAddress ipa = IPAddress.Parse(ip);

        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
