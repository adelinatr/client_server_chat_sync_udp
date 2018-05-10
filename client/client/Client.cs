using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientChatWF
{
	public class Client
	{
		public Socket socket { set; get; }
		public EndPoint remoteEp;
		User user;
		
		public Client(string ip_address_text, string port_text)
		{
			socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			IPAddress ip = IPAddress.Parse(ip_address_text);
			remoteEp = new IPEndPoint(ip, int.Parse(port_text));
			user = new User();
			user.Port = port_text;
			user.IpAddress = ip_address_text;
		}

		public void SendJoinMsg(string username_text)
		{
			user.Username = username_text;
			byte[] bt = Encoding.ASCII.GetBytes($"{username_text}:join");
			socket.SendTo(bt, remoteEp);
		}

		public void SendMsg(string username_text, string selected_user, string mNewMessage)
		{
			byte[] data = Encoding.ASCII.GetBytes($"{username_text}:{selected_user}#{mNewMessage}");
			if (data != null)
			{
				socket.SendTo(data, remoteEp);
			}
		}
		
		public void SendQuit(string username)
		{
			socket.SendTo(Encoding.ASCII.GetBytes($"{username}:quit"), remoteEp);
		}

		public int Receive(byte[] data)
		{
			return socket.ReceiveFrom(data, ref remoteEp);
		}
	}
}
