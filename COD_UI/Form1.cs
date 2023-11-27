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
		private void tbUsername_Enter(object sender, EventArgs e) { if (tbUsername.Text == Data.TB_USERNAME_DEFAULT_VALUE) tbUsername.Text = string.Empty; }
		private void tbPassword_Enter(object sender, EventArgs e) { if (tbPassword.Text == Data.TB_PASSWORD_DEFAULT_VALUE) tbPassword.Text = string.Empty; }
		

		private void tbUsername_Leave(object sender, EventArgs e) { if (tbUsername.Text.Trim(' ') == string.Empty) tbUsername.Text = Data.TB_USERNAME_DEFAULT_VALUE; }
		private void tbPassword_Leave(object sender, EventArgs e) { if (tbPassword.Text.Trim(' ') == string.Empty) tbPassword.Text = Data.TB_PASSWORD_DEFAULT_VALUE; }


		// click listener
		private void btnLogin_Click(object sender, EventArgs e)
		{
			// connect to db

			// check auth
			//// switch (requestResult) {
			////	case "admin": LoadAdminForm();
			////	case "manager": LoadManagerForm();
			////	case "analytic": LoadAnalyticForm();
			//// }

			// load main form
		}

		private void btnContinueAsClient_Click(object sender, EventArgs e)
		{
			Visible = false;
			new ContractForm(this).Show();
		}
	}
}
