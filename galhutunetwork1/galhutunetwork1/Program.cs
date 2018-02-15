using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
namespace galhutunetwork1
{
    class Program   
    {
        static void Main(string[] args)
        {
            //IPEndPoint localEP= new IPEndPoint

            Socket s = new Socket(AddressFamily.InterNetwork,
            SocketType.Dgram, ProtocolType.Udp);


            IPAddress ipa = IPAddress.Parse("127.0.0.1");
            Console.WriteLine("IP address is=" + ipa.ToString());

            Console.WriteLine("IP address is=" + IPAddress.Loopback.ToString());
            Console.WriteLine("Broadcast address is=" + IPAddress.Broadcast.ToString());
        }
    }
}
