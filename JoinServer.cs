using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAppForms
{
    public partial class JoinServer : Form
    {
        //vars
        public int intPort;
        public IPAddress IPa;
        public string strName;
        public string strServerPasswd;
        public bool blBtSendClick;
        clsTCPClient mobjTCPClient = new clsTCPClient();



        public JoinServer()
        {
            InitializeComponent();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPort.Text != string.Empty)
                {
                    intPort = Convert.ToInt32(txtPort.Text);
                }
                if (txtPasswd.Text != string.Empty)
                {
                    strServerPasswd = txtPasswd.Text;
                } else { strServerPasswd = string.Empty; }
                if (txtIPa.Text != string.Empty)
                {
                    IPa = IPAddress.Parse(txtIPa.Text);
                }
                if (txtName.Text != string.Empty)
                {
                    strName = txtName.Text;
                } else { strName = "anon"; }

                mobjTCPClient.intPort = intPort;
                mobjTCPClient.ipaIPAddress = IPa;
                mobjTCPClient.strPasswd = strServerPasswd;
                mobjTCPClient.strName = strName;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            Thread.Sleep(5000);
            blBtSendClick = true;
            this.Hide();
            this.Close();
        }
    }
}
