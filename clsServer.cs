//--------------------------------------------------------------------------------------------------------
//      Class: Functions for Server side
//      Author: D-Fox-LTL
//      Date:   20.june 2023
//--------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAppForms.Server
{
    public class clsServer
    {
        //  vars
        TcpListener tcpListener;
        bool blServerRunning = false;




        public clsServer() 
        {

        }


        //Will display host IPas
        public void WhatIsMyIP(TextBox txtBox)
        {
            txtBox.Text = "Your IPv4 address is: ";
            var host = Dns.GetHostEntry(Dns.GetHostName());
            string IPa = null;
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    //IPa.add( ip.ToString());
                    txtBox.Text += "\r\n" + ip.ToString();
                }
            }
        }

        public void SetUpChatroom()
        {
            Console.WriteLine("On which port do you want your server to run on?: ");
            var varYourPort = Console.ReadLine();

            try
            {
                tcpListener = new TcpListener(Convert.ToInt32(varYourPort));
                tcpListener.Start();
                Console.WriteLine("You've succesfully made a server");
                blServerRunning = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
