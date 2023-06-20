namespace ChatAppForms
{
    partial class ChatClient
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
            this.txtSendMessage = new System.Windows.Forms.TextBox();
            this.btSendMessage = new System.Windows.Forms.Button();
            this.txtWhoIsHereClient = new System.Windows.Forms.TextBox();
            this.menuStripClient = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joinServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.btExitChatRm = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.menuStripClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSendMessage
            // 
            this.txtSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSendMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSendMessage.Location = new System.Drawing.Point(0, 447);
            this.txtSendMessage.Multiline = true;
            this.txtSendMessage.Name = "txtSendMessage";
            this.txtSendMessage.Size = new System.Drawing.Size(572, 33);
            this.txtSendMessage.TabIndex = 3;
            this.txtSendMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btSendMessage
            // 
            this.btSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSendMessage.BackColor = System.Drawing.Color.LightGray;
            this.btSendMessage.Location = new System.Drawing.Point(578, 447);
            this.btSendMessage.Name = "btSendMessage";
            this.btSendMessage.Size = new System.Drawing.Size(69, 33);
            this.btSendMessage.TabIndex = 4;
            this.btSendMessage.Text = "Send";
            this.btSendMessage.UseVisualStyleBackColor = false;
            // 
            // txtWhoIsHereClient
            // 
            this.txtWhoIsHereClient.BackColor = System.Drawing.SystemColors.Window;
            this.txtWhoIsHereClient.Location = new System.Drawing.Point(653, 26);
            this.txtWhoIsHereClient.Multiline = true;
            this.txtWhoIsHereClient.Name = "txtWhoIsHereClient";
            this.txtWhoIsHereClient.ReadOnly = true;
            this.txtWhoIsHereClient.Size = new System.Drawing.Size(383, 315);
            this.txtWhoIsHereClient.TabIndex = 10;
            // 
            // menuStripClient
            // 
            this.menuStripClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStripClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.clientOptionsToolStripMenuItem,
            this.themesToolStripMenuItem,
            this.chatToolStripMenuItem});
            this.menuStripClient.Location = new System.Drawing.Point(0, 0);
            this.menuStripClient.Name = "menuStripClient";
            this.menuStripClient.Size = new System.Drawing.Size(1048, 24);
            this.menuStripClient.TabIndex = 11;
            this.menuStripClient.Text = "menuStripClient";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // clientOptionsToolStripMenuItem
            // 
            this.clientOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.joinServerToolStripMenuItem,
            this.exitServerToolStripMenuItem});
            this.clientOptionsToolStripMenuItem.Name = "clientOptionsToolStripMenuItem";
            this.clientOptionsToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.clientOptionsToolStripMenuItem.Text = "Client options";
            // 
            // joinServerToolStripMenuItem
            // 
            this.joinServerToolStripMenuItem.Name = "joinServerToolStripMenuItem";
            this.joinServerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.joinServerToolStripMenuItem.Text = "Join Server";
            this.joinServerToolStripMenuItem.Click += new System.EventHandler(this.joinServerToolStripMenuItem_Click);
            // 
            // exitServerToolStripMenuItem
            // 
            this.exitServerToolStripMenuItem.Name = "exitServerToolStripMenuItem";
            this.exitServerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitServerToolStripMenuItem.Text = "Exit server";
            this.exitServerToolStripMenuItem.Click += new System.EventHandler(this.exitServerToolStripMenuItem_Click);
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightThemeToolStripMenuItem,
            this.darkThemeToolStripMenuItem});
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.themesToolStripMenuItem.Text = "Themes";
            // 
            // lightThemeToolStripMenuItem
            // 
            this.lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem";
            this.lightThemeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.lightThemeToolStripMenuItem.Text = "Light theme";
            // 
            // darkThemeToolStripMenuItem
            // 
            this.darkThemeToolStripMenuItem.Name = "darkThemeToolStripMenuItem";
            this.darkThemeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.darkThemeToolStripMenuItem.Text = "Dark theme";
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSizeToolStripMenuItem});
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.chatToolStripMenuItem.Text = "Chat";
            // 
            // fontSizeToolStripMenuItem
            // 
            this.fontSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pxToolStripMenuItem,
            this.pxToolStripMenuItem1,
            this.pxToolStripMenuItem2,
            this.pxToolStripMenuItem3,
            this.pxToolStripMenuItem4,
            this.pxToolStripMenuItem5});
            this.fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            this.fontSizeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.fontSizeToolStripMenuItem.Text = "Font size";
            // 
            // pxToolStripMenuItem
            // 
            this.pxToolStripMenuItem.Name = "pxToolStripMenuItem";
            this.pxToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pxToolStripMenuItem.Text = "10 px";
            // 
            // pxToolStripMenuItem1
            // 
            this.pxToolStripMenuItem1.Name = "pxToolStripMenuItem1";
            this.pxToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.pxToolStripMenuItem1.Text = "12 px";
            // 
            // pxToolStripMenuItem2
            // 
            this.pxToolStripMenuItem2.Name = "pxToolStripMenuItem2";
            this.pxToolStripMenuItem2.Size = new System.Drawing.Size(102, 22);
            this.pxToolStripMenuItem2.Text = "14 px";
            // 
            // pxToolStripMenuItem3
            // 
            this.pxToolStripMenuItem3.Name = "pxToolStripMenuItem3";
            this.pxToolStripMenuItem3.Size = new System.Drawing.Size(102, 22);
            this.pxToolStripMenuItem3.Text = "16 px";
            // 
            // pxToolStripMenuItem4
            // 
            this.pxToolStripMenuItem4.Name = "pxToolStripMenuItem4";
            this.pxToolStripMenuItem4.Size = new System.Drawing.Size(102, 22);
            this.pxToolStripMenuItem4.Text = "18 px";
            // 
            // pxToolStripMenuItem5
            // 
            this.pxToolStripMenuItem5.Name = "pxToolStripMenuItem5";
            this.pxToolStripMenuItem5.Size = new System.Drawing.Size(102, 22);
            this.pxToolStripMenuItem5.Text = "20 px";
            // 
            // btExitChatRm
            // 
            this.btExitChatRm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExitChatRm.BackColor = System.Drawing.Color.LightGray;
            this.btExitChatRm.Location = new System.Drawing.Point(754, 388);
            this.btExitChatRm.Name = "btExitChatRm";
            this.btExitChatRm.Size = new System.Drawing.Size(205, 33);
            this.btExitChatRm.TabIndex = 12;
            this.btExitChatRm.Text = "Exit chatroom";
            this.btExitChatRm.UseVisualStyleBackColor = false;
            // 
            // txtChat
            // 
            this.txtChat.BackColor = System.Drawing.SystemColors.Window;
            this.txtChat.Location = new System.Drawing.Point(0, 26);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.Size = new System.Drawing.Size(647, 418);
            this.txtChat.TabIndex = 13;
            // 
            // ChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 480);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.btExitChatRm);
            this.Controls.Add(this.menuStripClient);
            this.Controls.Add(this.txtWhoIsHereClient);
            this.Controls.Add(this.btSendMessage);
            this.Controls.Add(this.txtSendMessage);
            this.MinimumSize = new System.Drawing.Size(200, 100);
            this.Name = "ChatClient";
            this.ShowIcon = false;
            this.Text = "ChatClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatClient_FormClosing);
            this.menuStripClient.ResumeLayout(false);
            this.menuStripClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSendMessage;
        private System.Windows.Forms.Button btSendMessage;
        private System.Windows.Forms.TextBox txtWhoIsHereClient;
        private System.Windows.Forms.MenuStrip menuStripClient;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem clientOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joinServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitServerToolStripMenuItem;
        private System.Windows.Forms.Button btExitChatRm;
        private System.Windows.Forms.TextBox txtChat;
    }
}