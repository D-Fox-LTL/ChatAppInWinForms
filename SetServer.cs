using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAppForms
{
    public partial class SetServer : Form
    {
        public int ServerPort;
        public string strServerPasswd = string.Empty;
        public bool blBtSendClick = false;
        public string strAdminName = string.Empty;

        public SetServer()
        {
            InitializeComponent();
        }

        private void btSetUp_Click(object sender, EventArgs e)
        {
            try { if (txtPort.Text != null) { ServerPort = int.Parse(txtPort.Text); } }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            if (txtPasswd.Text != null) { strServerPasswd = txtPasswd.Text; }
            else { strServerPasswd = string.Empty; }
            if (txtAdminName.Text != string.Empty) { strAdminName = txtAdminName.Text; }
            else { strAdminName = "ServerAdmin"; }
            blBtSendClick = true;
            Thread.Sleep(5000);
            this.Hide();
            this.Close();
        }
    }
}
