namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textFriendsIp = new System.Windows.Forms.TextBox();
            this.textFriendsPort = new System.Windows.Forms.TextBox();
            this.yourIp_label = new System.Windows.Forms.Label();
            this.YourPort_label = new System.Windows.Forms.Label();
            this.friendIP_label = new System.Windows.Forms.Label();
            this.friendPort_Label = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.server_groupBox = new System.Windows.Forms.GroupBox();
            this.message_groupBox = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.server_groupBox.SuspendLayout();
            this.message_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textLocalIp
            // 
            this.textLocalIp.Location = new System.Drawing.Point(126, 23);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new System.Drawing.Size(100, 20);
            this.textLocalIp.TabIndex = 0;
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(126, 55);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(100, 20);
            this.textLocalPort.TabIndex = 1;
            // 
            // textFriendsIp
            // 
            this.textFriendsIp.Location = new System.Drawing.Point(393, 23);
            this.textFriendsIp.Name = "textFriendsIp";
            this.textFriendsIp.Size = new System.Drawing.Size(100, 20);
            this.textFriendsIp.TabIndex = 2;
            // 
            // textFriendsPort
            // 
            this.textFriendsPort.Location = new System.Drawing.Point(393, 55);
            this.textFriendsPort.Name = "textFriendsPort";
            this.textFriendsPort.Size = new System.Drawing.Size(100, 20);
            this.textFriendsPort.TabIndex = 3;
            // 
            // yourIp_label
            // 
            this.yourIp_label.AutoSize = true;
            this.yourIp_label.Location = new System.Drawing.Point(27, 26);
            this.yourIp_label.Name = "yourIp_label";
            this.yourIp_label.Size = new System.Drawing.Size(38, 13);
            this.yourIp_label.TabIndex = 4;
            this.yourIp_label.Text = "YourIp";
            // 
            // YourPort_label
            // 
            this.YourPort_label.AutoSize = true;
            this.YourPort_label.Location = new System.Drawing.Point(27, 58);
            this.YourPort_label.Name = "YourPort_label";
            this.YourPort_label.Size = new System.Drawing.Size(51, 13);
            this.YourPort_label.TabIndex = 5;
            this.YourPort_label.Text = "Your Port";
            // 
            // friendIP_label
            // 
            this.friendIP_label.AutoSize = true;
            this.friendIP_label.Location = new System.Drawing.Point(276, 22);
            this.friendIP_label.Name = "friendIP_label";
            this.friendIP_label.Size = new System.Drawing.Size(56, 13);
            this.friendIP_label.TabIndex = 6;
            this.friendIP_label.Text = "Friend\'s IP";
            // 
            // friendPort_Label
            // 
            this.friendPort_Label.AutoSize = true;
            this.friendPort_Label.Location = new System.Drawing.Point(276, 58);
            this.friendPort_Label.Name = "friendPort_Label";
            this.friendPort_Label.Size = new System.Drawing.Size(65, 13);
            this.friendPort_Label.TabIndex = 7;
            this.friendPort_Label.Text = "Friend\'s Port";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(540, 39);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.Location = new System.Drawing.Point(17, 19);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(209, 186);
            this.listMessage.TabIndex = 9;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(17, 241);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(209, 20);
            this.textMessage.TabIndex = 10;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(232, 239);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 11;
            this.buttonSend.Text = "SEND";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // server_groupBox
            // 
            this.server_groupBox.Controls.Add(this.yourIp_label);
            this.server_groupBox.Controls.Add(this.YourPort_label);
            this.server_groupBox.Controls.Add(this.textLocalIp);
            this.server_groupBox.Controls.Add(this.textLocalPort);
            this.server_groupBox.Controls.Add(this.buttonStart);
            this.server_groupBox.Controls.Add(this.textFriendsIp);
            this.server_groupBox.Controls.Add(this.friendPort_Label);
            this.server_groupBox.Controls.Add(this.textFriendsPort);
            this.server_groupBox.Controls.Add(this.friendIP_label);
            this.server_groupBox.Location = new System.Drawing.Point(28, 27);
            this.server_groupBox.Name = "server_groupBox";
            this.server_groupBox.Size = new System.Drawing.Size(625, 100);
            this.server_groupBox.TabIndex = 12;
            this.server_groupBox.TabStop = false;
            this.server_groupBox.Text = "Server Details";
            // 
            // message_groupBox
            // 
            this.message_groupBox.Controls.Add(this.listMessage);
            this.message_groupBox.Controls.Add(this.buttonSend);
            this.message_groupBox.Controls.Add(this.textMessage);
            this.message_groupBox.Location = new System.Drawing.Point(28, 168);
            this.message_groupBox.Name = "message_groupBox";
            this.message_groupBox.Size = new System.Drawing.Size(341, 291);
            this.message_groupBox.TabIndex = 9;
            this.message_groupBox.TabStop = false;
            this.message_groupBox.Text = "Message";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(444, 187);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 186);
            this.listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 500);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.message_groupBox);
            this.Controls.Add(this.server_groupBox);
            this.Name = "Form1";
            this.Text = "Pal Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.server_groupBox.ResumeLayout(false);
            this.server_groupBox.PerformLayout();
            this.message_groupBox.ResumeLayout(false);
            this.message_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textLocalIp;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textFriendsIp;
        private System.Windows.Forms.TextBox textFriendsPort;
        private System.Windows.Forms.Label yourIp_label;
        private System.Windows.Forms.Label YourPort_label;
        private System.Windows.Forms.Label friendIP_label;
        private System.Windows.Forms.Label friendPort_Label;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.GroupBox server_groupBox;
        private System.Windows.Forms.GroupBox message_groupBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

