using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_User_PLAYGROUND
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            JoinRoom jr = new JoinRoom();
            jr.Show();
        }

        private void buttonAddChat_Click(object sender, EventArgs e)
        {
            AddChat addChat = new AddChat();
            addChat.Show();
        }
    }
}
