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

            int noOfBytesReceived;
            Byte[] bytesReceived;
            while (true)
            {
                noOfBytesReceived = 0;
                bytesReceived = new Byte[1024];
                noOfBytesReceived = socket.ReceiveFrom(bytesReceived, ref remoteEP);

                string message = Encoding.ASCII.GetString(bytesReceived, 0, noOfBytesReceived);

                switch (message)
                {
                    case "join":
                        Console.WriteLine("client joined");
                        break;
                    case "quit":
                        Console.WriteLine("client quit");
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
