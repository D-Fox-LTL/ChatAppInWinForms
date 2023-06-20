using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAppForms
{
    public partial class ucSetServer : UserControl
    {
        public int ServerPort;
        public string ServerPasswd = string.Empty;
        public bool blBtSendClick = false;

        public ucSetServer()
        {
            InitializeComponent();
        }

        private void btSendPortAndPasswd_Click(object sender, EventArgs e)
        {
            try { if(txtPort.Text != null) { ServerPort = int.Parse(txtPort.Text); }  }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            if (txtPasswd.Text != null) { ServerPasswd = txtPasswd.Text; }
            else { ServerPasswd = null; }
            blBtSendClick = true;
        }
    }
}
