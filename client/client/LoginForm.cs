using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientChatWF
{
	public partial class LoginForm : Form
	{
		ClientForm form;
		bool loginNotPressed;
		public LoginForm(ClientForm _form)
		{
			InitializeComponent();
			this.Text = "Login";
			form = _form;
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			string name = textBoxUsername.Text;
			string pass = textBoxPassword.Text;
			bool invalidLogin = false;
			labelStatus.Text = "";
			if (name.Length < 4)
			{
				labelStatus.Text += "Name needs 4 or more characters\n";
				invalidLogin = true;
			}
			if (pass.Length < 4)
			{ 
				labelStatus.Text += "Password needs 4 or more characters\n";
				invalidLogin = true;
			}
			if (invalidLogin)
			{
				loginNotPressed = true;
                return;
			}
			form.UpdateCredentials(name, pass);
			Close();
		}

		private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (loginNotPressed)
				form.Close();
		}
	}
}
