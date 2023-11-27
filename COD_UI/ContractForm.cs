using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace COD_UI
{
	public partial class ContractForm : Form
	{
		private Form Caller;

		private List<string> typesOfService = new List<string>();


		public ContractForm(Form caller)
		{
			InitializeComponent();
			Caller = caller;

			typesOfService.AddRange(cbServiceTypeSelector.Items.Cast<string>());

			// fill equipment list from db
			string connectionString = "Host=192.168.1.48;Username=postgres;Password=P0stgrePass;Database=coddb";

			var connection = new NpgsqlConnection(connectionString);

			try
			{
				connection.Open();

				NpgsqlCommand command = new NpgsqlCommand("select * from equipment", connection);
				NpgsqlDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{
					lvEquipmentList.Items.Add(reader.GetString(1));
				}

				connection.Close();
			} catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		// add pretty interaction this text boxes

		// style text boxes
		private void tbClientPassportDetails_Enter(object sender, EventArgs e) { if (tbClientPassportDetails.Text == Data.TB_CLIENT_PASSPORT_DETAILS_DEFAULT_VALUE) tbClientPassportDetails.Text = string.Empty; }
		private void tbClientPassportDetails_Leave(object sender, EventArgs e) { if (tbClientPassportDetails.Text.Trim(' ') == string.Empty) tbClientPassportDetails.Text = Data.TB_CLIENT_PASSPORT_DETAILS_DEFAULT_VALUE; }
		
		private void tbClientPhoneNumber_Enter(object sender, EventArgs e) { if (tbClientPhoneNumber.Text == Data.TB_CLIENT_PHONE_NUMBER_DEFAULT_VALUE) tbClientPhoneNumber.Text = "+"; }
		private void tbClientPhoneNumber_Leave(object sender, EventArgs e) { if (tbClientPhoneNumber.Text.Trim(' ') == "+") tbClientPhoneNumber.Text = Data.TB_CLIENT_PHONE_NUMBER_DEFAULT_VALUE; }
		
		private void tbEquipmentAmount_Enter(object sender, EventArgs e) { if (tbEquipmentAmount.Text.Trim() == "0") tbEquipmentAmount.Text = string.Empty; }
		private void tbEquipmentAmount_Leave(object sender, EventArgs e) { if (tbEquipmentAmount.Text.Trim() == string.Empty) tbEquipmentAmount.Text = "0"; }

		// return to Login Form
		private void ContractForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Caller.Visible = true;
		}

		// add item to equip list
		private void btnApplyEquipment_Click(object sender, EventArgs e)
		{
			string amount = tbEquipmentAmount.Text.Trim();
			// check selections
			if (lvEquipmentList.CheckedItems.Count == 0)
			{
				new AlertDialog("Please, select at least one equipment item").ShowDialog();
				return;
			}
			if (amount == "0")
			{
				new AlertDialog("Please, enter valid amount of equipment").ShowDialog();
				return;
			}

			// extend main window
			if (lvChoosenEquipment.Items.Count == 0)
			{
				Size = new Size(Data.WINDOW_WIDTH_EXTENDED, Height);
				scResultsSplitter.Panel2Collapsed = false;
				scResultsSplitter.SplitterDistance = Data.RESULT_SPLITTER_DISTANCE;
				btnSubmit.Enabled = true;
			}

			// extract selected item
			ListViewItem equipToSave = new ListViewItem(lvEquipmentList.CheckedItems[0].Text);
			equipToSave.SubItems.Add(amount);
			lvChoosenEquipment.Items.Add(equipToSave);

			// clear selection
			foreach (ListViewItem item in lvEquipmentList.Items) item.Checked = false;

		}

		// clear selections
		private void lvEquipmentList_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			if (e.Item.Checked)
			{
				foreach (ListViewItem item in lvEquipmentList.Items)
				{
					if (item.Index != e.Item.Index) item.Checked = false;
				}
			}
		}

		// submit contract
		private void btnSubmit_Click(object sender, EventArgs e)
		{
			// check all fields

			// validate data

			// send it to db

			new AlertDialog("Your contract submitted").ShowDialog();
		}
	}
}
