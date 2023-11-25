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
	public partial class ContractForm : Form
	{
		private Form Caller;
		public ContractForm(Form caller)
		{
			InitializeComponent();
			Caller = caller;

			// fill combo box from db

			// fill equipment list from db
		}

		// add pretty interaction this text boxes

		// style text boxes
		private void tbClientPassportDetails_Enter(object sender, EventArgs e)
		{
			if (tbClientPassportDetails.Text == Data.TB_CLIENT_PASSPORT_DETAILS_DEFAULT_VALUE) tbClientPassportDetails.Text = string.Empty;
		}
		private void tbClientPhoneNumber_Enter(object sender, EventArgs e)
		{
			if (tbClientPhoneNumber.Text == Data.TB_CLIENT_PHONE_NUMBER_DEFAULT_VALUE) tbClientPhoneNumber.Text = "+";
		}
		private void tbClientPassportDetails_Leave(object sender, EventArgs e)
		{
			if (tbClientPassportDetails.Text.Trim(' ') == string.Empty)
				tbClientPassportDetails.Text = Data.TB_CLIENT_PASSPORT_DETAILS_DEFAULT_VALUE;
		}
		private void tbClientPhoneNumber_Leave(object sender, EventArgs e)
		{
			if (tbClientPhoneNumber.Text.Trim(' ') == string.Empty)
				tbClientPhoneNumber.Text = Data.TB_CLIENT_PHONE_NUMBER_DEFAULT_VALUE;
		}

		// return to Login Form
		private void ContractForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Caller.Visible = true;
		}

		// add item to equip list
		private void btnApplyEquipment_Click(object sender, EventArgs e)
		{
			ListViewItem choosenEquipmentItem = lvEquipmentList.CheckedItems[0];
			string amount = tbEquipmentAmount.Text;
		}
	}
}
