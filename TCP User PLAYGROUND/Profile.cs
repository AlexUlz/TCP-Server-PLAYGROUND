using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_User_PLAYGROUND
{
    public partial class Profile : Form
    {
        private string username;

        public Profile()
        {         
            InitializeComponent();
            textBoxIP.Text = GetLocalIPAddress();
        }

        private void buttonConfirmProfile_Click(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;
            this.Close();
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }
}
