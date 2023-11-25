namespace COD_UI
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnLogin = new System.Windows.Forms.Button();
			this.tbUsername = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.btnContinueAsClient = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnLogin.Location = new System.Drawing.Point(8, 198);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(338, 58);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Log In";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// tbUsername
			// 
			this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbUsername.Location = new System.Drawing.Point(8, 90);
			this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.Size = new System.Drawing.Size(339, 26);
			this.tbUsername.TabIndex = 1;
			this.tbUsername.Text = "Enter your username";
			this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Enter);
			this.tbUsername.Leave += new System.EventHandler(this.tbUsername_Leave);
			// 
			// tbPassword
			// 
			this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbPassword.Location = new System.Drawing.Point(8, 138);
			this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(339, 26);
			this.tbPassword.TabIndex = 2;
			this.tbPassword.Text = "Enter your password";
			this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
			this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
			// 
			// btnContinueAsClient
			// 
			this.btnContinueAsClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnContinueAsClient.Location = new System.Drawing.Point(8, 268);
			this.btnContinueAsClient.Margin = new System.Windows.Forms.Padding(2);
			this.btnContinueAsClient.Name = "btnContinueAsClient";
			this.btnContinueAsClient.Size = new System.Drawing.Size(338, 36);
			this.btnContinueAsClient.TabIndex = 3;
			this.btnContinueAsClient.Text = "Continue as Client";
			this.btnContinueAsClient.UseVisualStyleBackColor = true;
			this.btnContinueAsClient.Click += new System.EventHandler(this.btnContinueAsClient_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 315);
			this.Controls.Add(this.btnContinueAsClient);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbUsername);
			this.Controls.Add(this.btnLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Auth";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox tbUsername;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Button btnContinueAsClient;
	}
}

