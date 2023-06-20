//--------------------------------------------------------------------------------------------------------
//      Class: Functions for client and server chat side
//      Author: D-Fox-LTL
//      Date:   17.june 2023
//--------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppForms.Chat
{
    internal class clsChat
    {
        public List<string> lstMessageList;
        public clsChat() { }


        public void AddData(string message)
        {
            lstMessageList.Add(message);
        }
    }
}
