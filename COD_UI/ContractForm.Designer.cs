namespace COD_UI
{
	partial class ContractForm
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
			this.scSetupContract = new System.Windows.Forms.SplitContainer();
			this.tbSetupContractLabel = new System.Windows.Forms.TextBox();
			this.lvEquipmentList = new System.Windows.Forms.ListView();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbEquipmentAmount = new System.Windows.Forms.TextBox();
			this.tbClientPhoneNumber = new System.Windows.Forms.TextBox();
			this.tbClientPassportDetails = new System.Windows.Forms.TextBox();
			this.btnApplyEquipment = new System.Windows.Forms.Button();
			this.cbServiceTypeSelector = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.labelServiceType = new System.Windows.Forms.Label();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.scResultsSplitter = new System.Windows.Forms.SplitContainer();
			this.lvChoosenEquipment = new System.Windows.Forms.ListView();
			this.lvColumnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvColumnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvColumnTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.scSetupContract)).BeginInit();
			this.scSetupContract.Panel1.SuspendLayout();
			this.scSetupContract.Panel2.SuspendLayout();
			this.scSetupContract.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scResultsSplitter)).BeginInit();
			this.scResultsSplitter.Panel1.SuspendLayout();
			this.scResultsSplitter.Panel2.SuspendLayout();
			this.scResultsSplitter.SuspendLayout();
			this.SuspendLayout();
			// 
			// scSetupContract
			// 
			this.scSetupContract.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scSetupContract.Location = new System.Drawing.Point(0, 0);
			this.scSetupContract.Margin = new System.Windows.Forms.Padding(2);
			this.scSetupContract.Name = "scSetupContract";
			this.scSetupContract.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// scSetupContract.Panel1
			// 
			this.scSetupContract.Panel1.Controls.Add(this.tbSetupContractLabel);
			this.scSetupContract.Panel1MinSize = 38;
			// 
			// scSetupContract.Panel2
			// 
			this.scSetupContract.Panel2.Controls.Add(this.lvEquipmentList);
			this.scSetupContract.Panel2.Controls.Add(this.label3);
			this.scSetupContract.Panel2.Controls.Add(this.label2);
			this.scSetupContract.Panel2.Controls.Add(this.label1);
			this.scSetupContract.Panel2.Controls.Add(this.tbEquipmentAmount);
			this.scSetupContract.Panel2.Controls.Add(this.tbClientPhoneNumber);
			this.scSetupContract.Panel2.Controls.Add(this.tbClientPassportDetails);
			this.scSetupContract.Panel2.Controls.Add(this.btnApplyEquipment);
			this.scSetupContract.Panel2.Controls.Add(this.cbServiceTypeSelector);
			this.scSetupContract.Panel2.Controls.Add(this.label4);
			this.scSetupContract.Panel2.Controls.Add(this.labelServiceType);
			this.scSetupContract.Panel2.Controls.Add(this.btnSubmit);
			this.scSetupContract.Size = new System.Drawing.Size(432, 528);
			this.scSetupContract.SplitterDistance = 38;
			this.scSetupContract.SplitterWidth = 3;
			this.scSetupContract.TabIndex = 4;
			// 
			// tbSetupContractLabel
			// 
			this.tbSetupContractLabel.Cursor = System.Windows.Forms.Cursors.Default;
			this.tbSetupContractLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbSetupContractLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbSetupContractLabel.Location = new System.Drawing.Point(0, 0);
			this.tbSetupContractLabel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.tbSetupContractLabel.Name = "tbSetupContractLabel";
			this.tbSetupContractLabel.ReadOnly = true;
			this.tbSetupContractLabel.Size = new System.Drawing.Size(432, 38);
			this.tbSetupContractLabel.TabIndex = 4;
			this.tbSetupContractLabel.TabStop = false;
			this.tbSetupContractLabel.Text = "Setup your Contract";
			this.tbSetupContractLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbSetupContractLabel.WordWrap = false;
			// 
			// lvEquipmentList
			// 
			this.lvEquipmentList.CheckBoxes = true;
			this.lvEquipmentList.HideSelection = false;
			this.lvEquipmentList.Location = new System.Drawing.Point(137, 214);
			this.lvEquipmentList.MultiSelect = false;
			this.lvEquipmentList.Name = "lvEquipmentList";
			this.lvEquipmentList.Scrollable = false;
			this.lvEquipmentList.ShowGroups = false;
			this.lvEquipmentList.Size = new System.Drawing.Size(283, 154);
			this.lvEquipmentList.TabIndex = 8;
			this.lvEquipmentList.TabStop = false;
			this.lvEquipmentList.TileSize = new System.Drawing.Size(10, 10);
			this.lvEquipmentList.UseCompatibleStateImageBehavior = false;
			this.lvEquipmentList.View = System.Windows.Forms.View.List;
			this.lvEquipmentList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvEquipmentList_ItemChecked);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(8, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(282, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Type your passport series and number:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(8, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(188, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Type your phone number:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 155);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(170, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Select Type of Service:";
			// 
			// tbEquipmentAmount
			// 
			this.tbEquipmentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbEquipmentAmount.Location = new System.Drawing.Point(246, 391);
			this.tbEquipmentAmount.Name = "tbEquipmentAmount";
			this.tbEquipmentAmount.Size = new System.Drawing.Size(47, 23);
			this.tbEquipmentAmount.TabIndex = 5;
			this.tbEquipmentAmount.Text = "0";
			this.tbEquipmentAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbEquipmentAmount.Enter += new System.EventHandler(this.tbEquipmentAmount_Enter);
			this.tbEquipmentAmount.Leave += new System.EventHandler(this.tbEquipmentAmount_Leave);
			// 
			// tbClientPhoneNumber
			// 
			this.tbClientPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbClientPhoneNumber.Location = new System.Drawing.Point(12, 98);
			this.tbClientPhoneNumber.Name = "tbClientPhoneNumber";
			this.tbClientPhoneNumber.Size = new System.Drawing.Size(205, 23);
			this.tbClientPhoneNumber.TabIndex = 1;
			this.tbClientPhoneNumber.Text = "+7 (916) 123-45-67";
			this.tbClientPhoneNumber.Enter += new System.EventHandler(this.tbClientPhoneNumber_Enter);
			this.tbClientPhoneNumber.Leave += new System.EventHandler(this.tbClientPhoneNumber_Leave);
			// 
			// tbClientPassportDetails
			// 
			this.tbClientPassportDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbClientPassportDetails.Location = new System.Drawing.Point(12, 37);
			this.tbClientPassportDetails.Name = "tbClientPassportDetails";
			this.tbClientPassportDetails.Size = new System.Drawing.Size(205, 23);
			this.tbClientPassportDetails.TabIndex = 0;
			this.tbClientPassportDetails.Text = "1234 123456";
			this.tbClientPassportDetails.Enter += new System.EventHandler(this.tbClientPassportDetails_Enter);
			this.tbClientPassportDetails.Leave += new System.EventHandler(this.tbClientPassportDetails_Leave);
			// 
			// btnApplyEquipment
			// 
			this.btnApplyEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnApplyEquipment.Location = new System.Drawing.Point(340, 386);
			this.btnApplyEquipment.Name = "btnApplyEquipment";
			this.btnApplyEquipment.Size = new System.Drawing.Size(80, 33);
			this.btnApplyEquipment.TabIndex = 3;
			this.btnApplyEquipment.Text = "Apply";
			this.btnApplyEquipment.UseVisualStyleBackColor = true;
			this.btnApplyEquipment.Click += new System.EventHandler(this.btnApplyEquipment_Click);
			// 
			// cbServiceTypeSelector
			// 
			this.cbServiceTypeSelector.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbServiceTypeSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbServiceTypeSelector.Items.AddRange(new object[] {
            "Аренда",
            "Размещение"});
			this.cbServiceTypeSelector.Location = new System.Drawing.Point(191, 153);
			this.cbServiceTypeSelector.Name = "cbServiceTypeSelector";
			this.cbServiceTypeSelector.Size = new System.Drawing.Size(121, 24);
			this.cbServiceTypeSelector.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(171, 391);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 20);
			this.label4.TabIndex = 1;
			this.label4.Text = "Amount:";
			// 
			// labelServiceType
			// 
			this.labelServiceType.AutoSize = true;
			this.labelServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelServiceType.Location = new System.Drawing.Point(12, 214);
			this.labelServiceType.Name = "labelServiceType";
			this.labelServiceType.Size = new System.Drawing.Size(119, 20);
			this.labelServiceType.TabIndex = 1;
			this.labelServiceType.Text = "Add Equipment";
			// 
			// btnSubmit
			// 
			this.btnSubmit.Enabled = false;
			this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSubmit.Location = new System.Drawing.Point(137, 431);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(134, 44);
			this.btnSubmit.TabIndex = 0;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// scResultsSplitter
			// 
			this.scResultsSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scResultsSplitter.IsSplitterFixed = true;
			this.scResultsSplitter.Location = new System.Drawing.Point(0, 0);
			this.scResultsSplitter.Margin = new System.Windows.Forms.Padding(0);
			this.scResultsSplitter.Name = "scResultsSplitter";
			// 
			// scResultsSplitter.Panel1
			// 
			this.scResultsSplitter.Panel1.Controls.Add(this.scSetupContract);
			// 
			// scResultsSplitter.Panel2
			// 
			this.scResultsSplitter.Panel2.Controls.Add(this.lvChoosenEquipment);
			this.scResultsSplitter.Panel2Collapsed = true;
			this.scResultsSplitter.Panel2MinSize = 200;
			this.scResultsSplitter.Size = new System.Drawing.Size(432, 528);
			this.scResultsSplitter.SplitterDistance = 332;
			this.scResultsSplitter.TabIndex = 5;
			// 
			// lvChoosenEquipment
			// 
			this.lvChoosenEquipment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvColumnName,
            this.lvColumnAmount,
            this.lvColumnTotalPrice});
			this.lvChoosenEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvChoosenEquipment.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvChoosenEquipment.HideSelection = false;
			this.lvChoosenEquipment.Location = new System.Drawing.Point(0, 0);
			this.lvChoosenEquipment.MultiSelect = false;
			this.lvChoosenEquipment.Name = "lvChoosenEquipment";
			this.lvChoosenEquipment.Scrollable = false;
			this.lvChoosenEquipment.Size = new System.Drawing.Size(219, 528);
			this.lvChoosenEquipment.TabIndex = 0;
			this.lvChoosenEquipment.UseCompatibleStateImageBehavior = false;
			this.lvChoosenEquipment.View = System.Windows.Forms.View.Details;
			// 
			// lvColumnName
			// 
			this.lvColumnName.Text = "Name";
			this.lvColumnName.Width = 150;
			// 
			// lvColumnAmount
			// 
			this.lvColumnAmount.Text = "Amount";
			this.lvColumnAmount.Width = 50;
			// 
			// lvColumnTotalPrice
			// 
			this.lvColumnTotalPrice.Text = "Total Price";
			this.lvColumnTotalPrice.Width = 100;
			// 
			// ContractForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 528);
			this.Controls.Add(this.scResultsSplitter);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ContractForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Data Operation Centers";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContractForm_FormClosing);
			this.scSetupContract.Panel1.ResumeLayout(false);
			this.scSetupContract.Panel1.PerformLayout();
			this.scSetupContract.Panel2.ResumeLayout(false);
			this.scSetupContract.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.scSetupContract)).EndInit();
			this.scSetupContract.ResumeLayout(false);
			this.scResultsSplitter.Panel1.ResumeLayout(false);
			this.scResultsSplitter.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scResultsSplitter)).EndInit();
			this.scResultsSplitter.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.SplitContainer scSetupContract;
		private System.Windows.Forms.TextBox tbSetupContractLabel;
		private System.Windows.Forms.TextBox tbClientPhoneNumber;
		private System.Windows.Forms.TextBox tbClientPassportDetails;
		private System.Windows.Forms.Button btnApplyEquipment;
		private System.Windows.Forms.ComboBox cbServiceTypeSelector;
		private System.Windows.Forms.Label labelServiceType;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.SplitContainer scResultsSplitter;
		private System.Windows.Forms.TextBox tbEquipmentAmount;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListView lvChoosenEquipment;
		private System.Windows.Forms.ColumnHeader lvColumnName;
		private System.Windows.Forms.ColumnHeader lvColumnAmount;
		private System.Windows.Forms.ListView lvEquipmentList;
		private System.Windows.Forms.ColumnHeader lvColumnTotalPrice;
	}
}