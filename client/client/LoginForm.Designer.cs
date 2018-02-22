namespace ClientChatWF
{
	partial class LoginForm
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
			this.buttonLogin = new System.Windows.Forms.Button();
			this.textBoxUsername = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.labelStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(50, 137);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(180, 23);
			this.buttonLogin.TabIndex = 0;
			this.buttonLogin.Text = "Login";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.Location = new System.Drawing.Point(50, 72);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(180, 20);
			this.textBoxUsername.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(50, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(180, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Username:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(50, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(50, 111);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(180, 20);
			this.textBoxPassword.TabIndex = 3;
			// 
			// labelStatus
			// 
			this.labelStatus.Location = new System.Drawing.Point(12, 167);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(260, 124);
			this.labelStatus.TabIndex = 5;
			this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 300);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxUsername);
			this.Controls.Add(this.buttonLogin);
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.TextBox textBoxUsername;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label labelStatus;
	}
}