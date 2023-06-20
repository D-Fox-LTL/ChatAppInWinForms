//--------------------------------------------------------------------------------------------------------
//      Class: TCPClient for chatroom client
//      Author: D-Fox-LTL
//      Date:   20.june 2023
//--------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAppForms
{
    internal class clsTCPClient
    {
                //vars
        public int intPort;
        public IPAddress ipaIPAddress;
        public string strPasswd;
        public string strName;
        private TcpClient tcpcClient;
        public bool blIsConnected = false;



        public void ServerConnect(IPAddress IPa, int Port)
        {
            try
            {
                tcpcClient = new TcpClient(IPa.ToString(), Port);
                blIsConnected = true;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                blIsConnected = false;
            }
        }

        public string GetMessageFromServer()
        {
            NetworkStream ntwStream = tcpcClient.GetStream();
            IFormatter formatter = new BinaryFormatter();
            try
            {
                string message = (string)formatter.Deserialize(ntwStream);
                return message;
            }
            catch (Exception ex)
            {

                string message = (string)formatter.Deserialize(ntwStream);
                MessageBox.Show(ex.Message);
                return message;
            }
        }
        public void SendMessageToServer(string message)
        {
            NetworkStream ntwStream = tcpcClient.GetStream();
            IFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(ntwStream, message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DataCheck(TextBox txtBox)
        {
            if(tcpcClient.GetStream().DataAvailable)
            {
                Thread.Sleep(50);
                string message = GetMessageFromServer();

                if(message != null)
                {
                    Thread thrProcessData = new Thread(() => this.ProcessData(message, txtBox));
                    thrProcessData.Start();
                }
            }
        }


        public void QuitCheck()
        {
            while (blIsConnected == true)
            {
                Socket socket = tcpcClient.Client;
                        //Determines the state of socket
                if (socket.Poll(10, SelectMode.SelectRead) && socket.Available == 0)
                {
                    blIsConnected = false;
                    MessageBox.Show("You were disconnected form a server");
                }
            }
        }

        public void ProcessData(string message, TextBox txtBox)
        {
            txtBox.Text = message + "\r";
        }
    }
}
