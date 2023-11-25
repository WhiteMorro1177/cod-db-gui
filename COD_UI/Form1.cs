using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COD_UI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		// styling
		private void tbUsername_Enter(object sender, EventArgs e) => tbUsername.Text = string.Empty;
		private void tbPassword_Enter(object sender, EventArgs e) => tbPassword.Text = string.Empty;
		

		private void tbUsername_Leave(object sender, EventArgs e) => tbUsername.Text = "Enter your username";
		private void tbPassword_Leave(object sender, EventArgs e) => tbPassword.Text = "Enter your password";

		// click listener
		private void btnLogin_Click(object sender, EventArgs e)
		{
			// connect to db
			// check auth

			string token = "token";

			// load main form
			ClientForm mf = new ClientForm(token);
		}
	}
}
