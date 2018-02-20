using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ServerSide
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPAddress ip = IPAddress.Parse("127.0.0.1");

            string classArgs = args[0];
            int port = int.Parse(classArgs);

            IPEndPoint localEP = new IPEndPoint(ip, port);

            Console.WriteLine("returned port is : " + port);
            Console.WriteLine("server started");

            socket.Bind(localEP);
            EndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);

            List<EndPoint> clients = new List<EndPoint>();

            int noOfBytesReceived;
            Byte[] bytesReceived;
            while (true)
            {
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
                        Console.WriteLine($"{user} joined");
                        break;
                    case "quit":
						clients.RemoveAt(clients.IndexOf(remoteEP));
                        Console.WriteLine($"{user} quit");
                        break;
					case "gettime":
						Console.WriteLine($"{user} actual time");
						string actual_time = DateTime.Now.ToString("hh:mm:ss tt");
						byte[] bytes = Encoding.ASCII.GetBytes(actual_time);
						socket.SendTo(bytes, remoteEP);

						break;
					default:
                        Console.WriteLine($"{user}: {text}");
                        break;
                }
            }
        }

    }
}
