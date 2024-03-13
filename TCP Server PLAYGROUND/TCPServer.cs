using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Server_PLAYGROUND
{
    public class TCPServer
    {
        static TcpListener _listener;
        static List<Manager> _users;
        public static void Main(string[] args)
        {
            _users = new List<Manager>();
            _listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 7891);
            _listener.Start();

            var Client = _listener.AcceptTcpClient();
            Console.WriteLine("Client has connected!");
            
            while (true)
            {
                var newClient = new Manager(_listener.AcceptTcpClient());
                _users.Add(newClient);
            }
        }
    }
}
