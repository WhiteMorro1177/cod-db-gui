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
	public partial class ClientForm : Form
	{
		private string Token { get; set; }
		public ClientForm(string token)
		{
			Token = token;
			InitializeComponent();
		}
	}
}
