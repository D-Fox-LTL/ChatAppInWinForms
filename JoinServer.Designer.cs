namespace ChatAppForms
{
    partial class JoinServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtWPTU = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSUYAN = new System.Windows.Forms.TextBox();
            this.txtIPa = new System.Windows.Forms.TextBox();
            this.txtIPTCT = new System.Windows.Forms.TextBox();
            this.txtSUYP = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(12, 38);
            this.txtPort.Multiline = true;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(158, 104);
            this.txtPort.TabIndex = 3;
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWPTU
            // 
            this.txtWPTU.Location = new System.Drawing.Point(12, 12);
            this.txtWPTU.Name = "txtWPTU";
            this.txtWPTU.ReadOnly = true;
            this.txtWPTU.Size = new System.Drawing.Size(158, 20);
            this.txtWPTU.TabIndex = 4;
            this.txtWPTU.Text = "Which port to connect to";
            this.txtWPTU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(176, 38);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(122, 34);
            this.txtName.TabIndex = 8;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSUYAN
            // 
            this.txtSUYAN.Location = new System.Drawing.Point(176, 12);
            this.txtSUYAN.Name = "txtSUYAN";
            this.txtSUYAN.ReadOnly = true;
            this.txtSUYAN.Size = new System.Drawing.Size(122, 20);
            this.txtSUYAN.TabIndex = 9;
            this.txtSUYAN.Text = "Set up your name";
            this.txtSUYAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIPa
            // 
            this.txtIPa.Location = new System.Drawing.Point(304, 38);
            this.txtIPa.Multiline = true;
            this.txtIPa.Name = "txtIPa";
            this.txtIPa.Size = new System.Drawing.Size(162, 104);
            this.txtIPa.TabIndex = 10;
            // 
            // txtIPTCT
            // 
            this.txtIPTCT.Location = new System.Drawing.Point(304, 12);
            this.txtIPTCT.Name = "txtIPTCT";
            this.txtIPTCT.ReadOnly = true;
            this.txtIPTCT.Size = new System.Drawing.Size(162, 20);
            this.txtIPTCT.TabIndex = 11;
            this.txtIPTCT.Text = "IPa to connect to";
            this.txtIPTCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSUYP
            // 
            this.txtSUYP.Location = new System.Drawing.Point(176, 78);
            this.txtSUYP.Name = "txtSUYP";
            this.txtSUYP.ReadOnly = true;
            this.txtSUYP.Size = new System.Drawing.Size(122, 20);
            this.txtSUYP.TabIndex = 12;
            this.txtSUYP.Text = "Set up your password";
            this.txtSUYP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(176, 104);
            this.txtPasswd.Multiline = true;
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(122, 38);
            this.txtPasswd.TabIndex = 13;
            this.txtPasswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btConfirm
            // 
            this.btConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.Location = new System.Drawing.Point(102, 148);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(268, 38);
            this.btConfirm.TabIndex = 14;
            this.btConfirm.Text = "Click here to send the info";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // JoinServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 226);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtSUYP);
            this.Controls.Add(this.txtIPTCT);
            this.Controls.Add(this.txtIPa);
            this.Controls.Add(this.txtSUYAN);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtWPTU);
            this.Controls.Add(this.txtPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JoinServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "JoinServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtWPTU;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSUYAN;
        private System.Windows.Forms.TextBox txtIPa;
        private System.Windows.Forms.TextBox txtIPTCT;
        private System.Windows.Forms.TextBox txtSUYP;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Button btConfirm;
    }
}