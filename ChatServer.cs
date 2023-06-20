using ChatAppForms.Chat;
using ChatAppForms.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAppForms
{
    public partial class ChatServer : Form
    {
        //used classes
        clsServer mobjServer = new clsServer();
        clsChat mobjChat = new clsChat();
        clsTCPServer mobjTCPServer = new clsTCPServer();
        SetServer mobjSetServer = new SetServer();

        //bool for exit control
        private bool blExit = false;
        //Threads
            //For checking data
            //for checking Quit
            //For listening for connections
        Thread thrData;
        Thread thrQuit;
        Thread thrListener;



        //passwd for the server (can stay empty)
        private string strServerPasswd = string.Empty;
        //Server port
        private int intServerPort;



        public ChatServer()
        {
            InitializeComponent();
            //Will put IPv4 addresses onto txtIPa
            mobjServer.WhatIsMyIP(txtIPa);
        }


        /// <summary>
        /// Exit button in the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Server is not running anymore
            mobjTCPServer.blServerRunning = false;
            //We exited
            blExit = true;
            //Exit app
            Application.Exit();
        }

        private void setServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opens form called SetServer
            SetServer SetServer = new SetServer();
            SetServer.ShowDialog();
            try
            {
                //Starts the server
                mobjTCPServer.StartServer(mobjSetServer.ServerPort);
                //Starts the threads
                StartThreads();
                //sets the server passwd
                strServerPasswd = mobjSetServer.strServerPasswd;
                //Server is running
                mobjTCPServer.blServerRunning = true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                //Stops the server if it started
                mobjTCPServer.StopServer();
                //Stops the threads if they started
                StopThreads();
                //resets passwd
                strServerPasswd = string.Empty;
                //Server is not running, some error
                mobjTCPServer.blServerRunning = false;
            }
        }




        /// <summary>
        /// When the app is closing by the button in the top right
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChatServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            //If the server is running, do this
            if (mobjTCPServer.blServerRunning == true)
            {
                //TODO: inform users that they were disconnected bcs of it
                mobjTCPServer.blServerRunning = false;

                mobjTCPServer.SendMessage("Server is being terminated", mobjTCPServer.SocketToUse);
                try 
                {
                    //Stops the server
                    mobjTCPServer.StopServer();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                try
                {
                    //Stops the threads
                    StopThreads();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

                //      ^^^     These are done separtely bcs we want the threads to end if some error occurs during stopping the server
            }
            blExit = true;
        }



        /// <summary>
        /// Exits the server, not the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If the server is running, do this, else do nothing
            if (mobjTCPServer.blServerRunning == true)
            {
                //\//\/\/\/\/\/\/\/\/\/\\//\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/
                //TODO: inform users that they were disconnected bcs of it
                ///\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\/\/\\/\\\//\\/\/\/



                System.Messaging.Message myMessage = new System.Messaging.Message("Server is being terminated", new BinaryMessageFormatter());

                mobjTCPServer.blServerRunning = false;
                try
                {
                    mobjTCPServer.StopServer();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                try
                {
                    StopThreads();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }


        /// <summary>
        /// sends message to other users
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSendMessage_Click(object sender, EventArgs e)
        {
            string strMessage = txtSendMessage.Text;
            if (strMessage.Trim() != string.Empty)
            {
                mobjTCPServer.SendMessage(strMessage, mobjTCPServer.SocketToUse);
            }
        }










        /// <summary>
        /// Starts threads
        /// First for checking data
        /// Second for checking quit
        /// Third for TCP listening
        /// </summary>
        private void StartThreads()
        {
            thrData = new Thread(() => mobjTCPServer.DataCheck(txtChat));
            thrQuit = new Thread(() => mobjTCPServer.QuitCheck(txtChat));
            thrListener = new Thread(() => mobjTCPServer.TCPListen(txtChat));

            thrData.Start();
            thrQuit.Start();
            thrListener.Start();
        }



        /// <summary>
        /// Stops threads
        /// </summary>
        private void StopThreads()
        {
            if (thrData.IsAlive == true) { thrData.Abort(); }
            if (thrQuit.IsAlive == true) { thrQuit.Abort(); }
            if (thrListener.IsAlive == true) { thrListener.Abort(); }
        }

        /// <summary>
        /// Verify passwd
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool VerifyPassword(string password)
        {
            return password == strServerPasswd;
        }
    }
}
