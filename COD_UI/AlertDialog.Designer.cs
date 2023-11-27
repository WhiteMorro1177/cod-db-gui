namespace COD_UI
{
	partial class AlertDialog
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
			this.alertMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// alertMessage
			// 
			this.alertMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.alertMessage.AutoSize = true;
			this.alertMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.alertMessage.Location = new System.Drawing.Point(12, 27);
			this.alertMessage.Name = "alertMessage";
			this.alertMessage.Size = new System.Drawing.Size(101, 26);
			this.alertMessage.TabIndex = 1;
			this.alertMessage.Text = "message";
			this.alertMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AlertDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 79);
			this.Controls.Add(this.alertMessage);
			this.Name = "AlertDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AlertDialog";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label alertMessage;
	}
}