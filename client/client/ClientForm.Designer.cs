namespace ClientChatWF
{
	partial class ClientForm
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
			this.statusLabel = new System.Windows.Forms.Label();
			this.textBoxMessage = new System.Windows.Forms.TextBox();
			this.buttonSend = new System.Windows.Forms.Button();
			this.buttonJoin = new System.Windows.Forms.Button();
			this.buttonQuit = new System.Windows.Forms.Button();
			this.textBoxIPAdress = new System.Windows.Forms.TextBox();
			this.textBoxPort = new System.Windows.Forms.TextBox();
			this.textBoxUsername = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.chatLog = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// statusLabel
			// 
			this.statusLabel.Location = new System.Drawing.Point(640, 14);
			this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(278, 60);
			this.statusLabel.TabIndex = 2;
			this.statusLabel.Text = "No connection";
			// 
			// textBoxMessage
			// 
			this.textBoxMessage.Location = new System.Drawing.Point(18, 677);
			this.textBoxMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxMessage.Multiline = true;
			this.textBoxMessage.Name = "textBoxMessage";
			this.textBoxMessage.Size = new System.Drawing.Size(800, 44);
			this.textBoxMessage.TabIndex = 3;
			// 
			// buttonSend
			// 
			this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSend.Location = new System.Drawing.Point(828, 677);
			this.buttonSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(90, 46);
			this.buttonSend.TabIndex = 4;
			this.buttonSend.Text = "Send";
			this.buttonSend.UseVisualStyleBackColor = true;
			this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
			// 
			// buttonJoin
			// 
			this.buttonJoin.Location = new System.Drawing.Point(428, 14);
			this.buttonJoin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonJoin.Name = "buttonJoin";
			this.buttonJoin.Size = new System.Drawing.Size(120, 54);
			this.buttonJoin.TabIndex = 5;
			this.buttonJoin.Text = "Join";
			this.buttonJoin.UseVisualStyleBackColor = true;
			this.buttonJoin.Click += new System.EventHandler(this.buttonJoin_Click);
			// 
			// buttonQuit
			// 
			this.buttonQuit.Location = new System.Drawing.Point(556, 14);
			this.buttonQuit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonQuit.Name = "buttonQuit";
			this.buttonQuit.Size = new System.Drawing.Size(75, 54);
			this.buttonQuit.TabIndex = 6;
			this.buttonQuit.Text = "Quit";
			this.buttonQuit.UseVisualStyleBackColor = true;
			this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
			// 
			// textBoxIPAdress
			// 
			this.textBoxIPAdress.Location = new System.Drawing.Point(18, 38);
			this.textBoxIPAdress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxIPAdress.Name = "textBoxIPAdress";
			this.textBoxIPAdress.Size = new System.Drawing.Size(163, 26);
			this.textBoxIPAdress.TabIndex = 7;
			// 
			// textBoxPort
			// 
			this.textBoxPort.Location = new System.Drawing.Point(192, 38);
			this.textBoxPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxPort.Name = "textBoxPort";
			this.textBoxPort.Size = new System.Drawing.Size(66, 26);
			this.textBoxPort.TabIndex = 8;
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.Location = new System.Drawing.Point(268, 38);
			this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(148, 26);
			this.textBoxUsername.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "Server IP Adress";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(204, 14);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Port";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(298, 14);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 20);
			this.label3.TabIndex = 12;
			this.label3.Text = "Username";
			// 
			// chatLog
			// 
			this.chatLog.AcceptsReturn = true;
			this.chatLog.AcceptsTab = true;
			this.chatLog.BackColor = System.Drawing.SystemColors.Control;
			this.chatLog.ForeColor = System.Drawing.SystemColors.MenuText;
			this.chatLog.Location = new System.Drawing.Point(18, 78);
			this.chatLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chatLog.Multiline = true;
			this.chatLog.Name = "chatLog";
			this.chatLog.ReadOnly = true;
			this.chatLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.chatLog.Size = new System.Drawing.Size(898, 582);
			this.chatLog.TabIndex = 16;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(858, 43);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(58, 31);
			this.button1.TabIndex = 17;
			this.button1.Text = "Sync Time";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(854, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 20);
			this.label4.TabIndex = 18;
			this.label4.Text = "Time";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// ClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(936, 740);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.chatLog);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxUsername);
			this.Controls.Add(this.textBoxPort);
			this.Controls.Add(this.textBoxIPAdress);
			this.Controls.Add(this.buttonQuit);
			this.Controls.Add(this.buttonJoin);
			this.Controls.Add(this.buttonSend);
			this.Controls.Add(this.textBoxMessage);
			this.Controls.Add(this.statusLabel);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ClientForm";
			this.Text = "Chat";
			this.ResizeBegin += new System.EventHandler(this.ClientForm_ResizeBegin);
			this.ResizeEnd += new System.EventHandler(this.ClientForm_ResizeEnd);
			this.ResumeLayout(false);
			this.PerformLayout();
    }

		#endregion
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.TextBox textBoxMessage;
		private System.Windows.Forms.Button buttonSend;
		private System.Windows.Forms.Button buttonJoin;
		private System.Windows.Forms.Button buttonQuit;
		private System.Windows.Forms.TextBox textBoxIPAdress;
		private System.Windows.Forms.TextBox textBoxPort;
		private System.Windows.Forms.TextBox textBoxUsername;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox chatLog;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
	}
}
