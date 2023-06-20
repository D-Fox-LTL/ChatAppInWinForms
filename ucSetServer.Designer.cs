namespace ChatAppForms
{
    partial class ucSetServer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtSimpleText = new System.Windows.Forms.TextBox();
            this.btSendPortAndPasswd = new System.Windows.Forms.Button();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.txtSimplePort = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(46, 126);
            this.txtPort.Multiline = true;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(126, 73);
            this.txtPort.TabIndex = 1;
            // 
            // txtSimpleText
            // 
            this.txtSimpleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSimpleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSimpleText.Location = new System.Drawing.Point(3, 36);
            this.txtSimpleText.Multiline = true;
            this.txtSimpleText.Name = "txtSimpleText";
            this.txtSimpleText.ReadOnly = true;
            this.txtSimpleText.Size = new System.Drawing.Size(510, 48);
            this.txtSimpleText.TabIndex = 2;
            this.txtSimpleText.Text = "Set up your server";
            this.txtSimpleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSendPortAndPasswd
            // 
            this.btSendPortAndPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSendPortAndPasswd.Location = new System.Drawing.Point(161, 262);
            this.btSendPortAndPasswd.Name = "btSendPortAndPasswd";
            this.btSendPortAndPasswd.Size = new System.Drawing.Size(194, 28);
            this.btSendPortAndPasswd.TabIndex = 3;
            this.btSendPortAndPasswd.Text = "Set port and passwd";
            this.btSendPortAndPasswd.UseVisualStyleBackColor = true;
            this.btSendPortAndPasswd.Click += new System.EventHandler(this.btSendPortAndPasswd_Click);
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(345, 126);
            this.txtPasswd.Multiline = true;
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(129, 73);
            this.txtPasswd.TabIndex = 4;
            // 
            // txtSimplePort
            // 
            this.txtSimplePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSimplePort.Location = new System.Drawing.Point(14, 90);
            this.txtSimplePort.Multiline = true;
            this.txtSimplePort.Name = "txtSimplePort";
            this.txtSimplePort.ReadOnly = true;
            this.txtSimplePort.Size = new System.Drawing.Size(192, 32);
            this.txtSimplePort.TabIndex = 5;
            this.txtSimplePort.Text = "Which port to use";
            this.txtSimplePort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(312, 88);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(192, 32);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Which passwd to use";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ucSetServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSimplePort);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.btSendPortAndPasswd);
            this.Controls.Add(this.txtSimpleText);
            this.Controls.Add(this.txtPort);
            this.Name = "ucSetServer";
            this.Size = new System.Drawing.Size(516, 321);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtSimpleText;
        private System.Windows.Forms.Button btSendPortAndPasswd;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.TextBox txtSimplePort;
        private System.Windows.Forms.TextBox textBox1;
    }
}
