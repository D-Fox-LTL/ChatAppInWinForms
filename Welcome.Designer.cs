namespace ChatAppForms
{
    partial class Welcome
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btChatAppSrv = new System.Windows.Forms.Button();
            this.btChatAppCli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Location = new System.Drawing.Point(12, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(476, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "What do you want to start?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btChatAppSrv
            // 
            this.btChatAppSrv.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChatAppSrv.Location = new System.Drawing.Point(12, 149);
            this.btChatAppSrv.Name = "btChatAppSrv";
            this.btChatAppSrv.Size = new System.Drawing.Size(184, 97);
            this.btChatAppSrv.TabIndex = 1;
            this.btChatAppSrv.Text = "ChatApp Server";
            this.btChatAppSrv.UseVisualStyleBackColor = true;
            this.btChatAppSrv.Click += new System.EventHandler(this.btChatAppSrv_Click);
            // 
            // btChatAppCli
            // 
            this.btChatAppCli.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChatAppCli.Location = new System.Drawing.Point(304, 149);
            this.btChatAppCli.Name = "btChatAppCli";
            this.btChatAppCli.Size = new System.Drawing.Size(184, 97);
            this.btChatAppCli.TabIndex = 2;
            this.btChatAppCli.Text = "ChatApp Client";
            this.btChatAppCli.UseVisualStyleBackColor = true;
            this.btChatAppCli.Click += new System.EventHandler(this.btChatAppCli_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(500, 282);
            this.Controls.Add(this.btChatAppCli);
            this.Controls.Add(this.btChatAppSrv);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatAppDFoxLTL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btChatAppSrv;
        private System.Windows.Forms.Button btChatAppCli;
    }
}

