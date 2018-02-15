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
			this.SuspendLayout();
			// 
			// statusLabel
			// 
			this.statusLabel.Location = new System.Drawing.Point(427, 9);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(185, 39);
			this.statusLabel.TabIndex = 2;
			this.statusLabel.Text = "No connection";
			// 
			// textBoxMessage
			// 
			this.textBoxMessage.Location = new System.Drawing.Point(12, 440);
			this.textBoxMessage.Multiline = true;
			this.textBoxMessage.Name = "textBoxMessage";
			this.textBoxMessage.Size = new System.Drawing.Size(535, 30);
			this.textBoxMessage.TabIndex = 3;
			// 
			// buttonSend
			// 
			this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSend.Location = new System.Drawing.Point(552, 440);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(60, 30);
			this.buttonSend.TabIndex = 4;
			this.buttonSend.Text = "Send";
			this.buttonSend.UseVisualStyleBackColor = true;
			// 
			// buttonJoin
			// 
			this.buttonJoin.Location = new System.Drawing.Point(285, 9);
			this.buttonJoin.Name = "buttonJoin";
			this.buttonJoin.Size = new System.Drawing.Size(80, 35);
			this.buttonJoin.TabIndex = 5;
			this.buttonJoin.Text = "Join";
			this.buttonJoin.UseVisualStyleBackColor = true;
			this.buttonJoin.Click += new System.EventHandler(this.buttonJoin_Click);
			// 
			// buttonQuit
			// 
			this.buttonQuit.Location = new System.Drawing.Point(371, 9);
			this.buttonQuit.Name = "buttonQuit";
			this.buttonQuit.Size = new System.Drawing.Size(50, 35);
			this.buttonQuit.TabIndex = 6;
			this.buttonQuit.Text = "Quit";
			this.buttonQuit.UseVisualStyleBackColor = true;
			// 
			// textBoxIPAdress
			// 
			this.textBoxIPAdress.Location = new System.Drawing.Point(12, 25);
			this.textBoxIPAdress.Name = "textBoxIPAdress";
			this.textBoxIPAdress.Size = new System.Drawing.Size(110, 20);
			this.textBoxIPAdress.TabIndex = 7;
			// 
			// textBoxPort
			// 
			this.textBoxPort.Location = new System.Drawing.Point(128, 25);
			this.textBoxPort.Name = "textBoxPort";
			this.textBoxPort.Size = new System.Drawing.Size(45, 20);
			this.textBoxPort.TabIndex = 8;
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.Location = new System.Drawing.Point(179, 25);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
			this.textBoxUsername.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Server IP Adress";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(136, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Port";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(199, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Username";
			// 
			// chatLog
			// 
			this.chatLog.AcceptsReturn = true;
			this.chatLog.AcceptsTab = true;
			this.chatLog.BackColor = System.Drawing.SystemColors.Control;
			this.chatLog.ForeColor = System.Drawing.SystemColors.MenuText;
			this.chatLog.Location = new System.Drawing.Point(12, 51);
			this.chatLog.Multiline = true;
			this.chatLog.Name = "chatLog";
			this.chatLog.ReadOnly = true;
			this.chatLog.Size = new System.Drawing.Size(600, 380);
			this.chatLog.TabIndex = 16;
			// 
			// ClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(624, 481);
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
			this.Name = "ClientForm";
			this.Text = "Chat";
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
	}
}

