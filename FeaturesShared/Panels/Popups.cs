using System;
using System.ComponentModel;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Alerts")]
	public partial class Popups : TestBase
	{
		public Popups()
		{
			InitializeComponent();
		}

		private void buttonShow_Click(object sender, EventArgs e)
		{
			if (Device.Valid)
			{
				try
				{
					var title = this.textBoxTitle.Text;
					var message = this.textBoxMessage.Text;

					if ((string)this.comboBoxPopupType.SelectedItem == "Prompt")
					{
						var result = Device.Popups.DisplayPrompt(title,message);

						AlertBox.Show($"Prompt closed: {result}", MessageBoxIcon.Information);
					}
					else if ((string)this.comboBoxPopupType.SelectedItem == "Alert")
					{
						Device.Popups.DisplayAlert(title, message, "Cancel");
					}
					else
					{
						var result = Device.Popups.DisplayActionSheet(
							title, 
							"Cancel", 
							"Other", 
							Shared.FlowDirection.LeftToRight, 
							new string[]
							{
								this.textBoxOption1.Text,
								this.textBoxOption2.Text,
								this.textBoxOption3.Text
							});

						AlertBox.Show($"Action sheet closed: {result}", MessageBoxIcon.Information);
					}
				}
				catch (DeviceException ex)
				{
					AlertBox.Show(ex.Message);
				}
			}
		}
	}
}
