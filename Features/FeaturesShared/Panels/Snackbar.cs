using System;
using System.ComponentModel;
using System.Drawing;
using Wisej.Hybrid.CommunityToolkit;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Alerts")]
	public partial class Snackbar : TestBase
	{
		public Snackbar()
		{
			InitializeComponent();

			Device.Use<DeviceSnackbar>().Dismissed += Snackbar_Dismissed;
			Device.Use<DeviceSnackbar>().ActionClicked += Snackbar_ActionClicked;
		}

		private void Snackbar_Dismissed(object sender, EventArgs e)
		{
			AlertBox.Show($"Snackbar dismissed");
		}

		private void Snackbar_ActionClicked(object sender, string e)
		{
			AlertBox.Show($"Clicked {e}");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Device.Use<DeviceSnackbar>().Show(
				this.textBoxMessage.Text, 
				this.textBoxAction.Text, 
				5, 
				new SnackbarOptions
				{
					Font = new Font("Open Sans", 14),
					ActionButtonTextColor = Color.Green,
					ActionButtonFont = new Font("Open Sans", 14),
				});
		}
	}
}
