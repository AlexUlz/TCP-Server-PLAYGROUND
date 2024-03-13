using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Server_PLAYGROUND
{
    internal class Manager
    {
        private string username { get; set; }
        private Guid id { get; set; }
        private TcpClient userClient { get; set; }


        public Manager(TcpClient client) 
        {
            userClient = client;
            id = Guid.NewGuid();

            Console.WriteLine("<{0}> {1} has connected to the server", DateTime.Now, username);

        }

    }
}
