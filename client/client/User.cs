using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientChatWF
{
	public class User
	{
		public User()
		{
			IpAddress = "";
			Port = "";
			Username = "";
		}

		public string IpAddress { set; get; }
		public string Port { set; get; }
		public string Username { set; get; }
	}
}
