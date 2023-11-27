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
	public partial class AlertDialog : Form
	{
		public AlertDialog(string message)
		{
			InitializeComponent();
			alertMessage.Text = message;

			int twoSidesOffset = 20;
			// get position
			Point messageLocation = alertMessage.Location;
			Size messageSize = alertMessage.Size;

			Size alertWindowSize = new Size(messageSize.Width + twoSidesOffset, Height);

			Size = alertWindowSize;

			alertMessage.Location = new Point(twoSidesOffset / 4, (Height / 2) - (alertMessage.Height / 2) - twoSidesOffset);
		}
	}
}
