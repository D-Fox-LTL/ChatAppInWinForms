using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ChatAppForms
{
    public partial class ChatClient : Form
    {
        clsTCPClient mobjTCPClient = new clsTCPClient();
        bool LoggedIn = false;
        Thread thrData;
        Thread thrQuit;

        public ChatClient()
        {
            InitializeComponent();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mobjTCPClient.blIsConnected = false;
            Application.Exit();
        }

        private void ChatClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mobjTCPClient.blIsConnected ==  false)
            {
                //TODO: inform server
            }
        }

        private void joinServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JoinServer joinServer = new JoinServer();
            joinServer.ShowDialog();


            try
            {
                mobjTCPClient.ServerConnect(mobjTCPClient.ipaIPAddress, mobjTCPClient.intPort);
                StartThreads();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void StartThreads()
        {
            thrData = new Thread(() => mobjTCPClient.DataCheck(txtChat));
            thrData.Start();
            thrQuit = new Thread(new ThreadStart(mobjTCPClient.QuitCheck));
            thrQuit.Start();
        }

        public void StopThreads() 
        {
            if (thrData.IsAlive == true) { thrData.Abort(); }
            if (thrQuit.IsAlive == true) { thrQuit.Abort(); }
        }

        private void exitServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopThreads();
        }
    }
}
