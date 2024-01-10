using System;
using System.Collections.Generic;
using System.ComponentModel;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Media")]
	public partial class Sms : TestBase
	{
		public Sms()
		{
			InitializeComponent();
		}

		private void Sms_Load(object sender, EventArgs e)
		{
			if (!Device.Sms.IsComposeSupported)
			{
				this.buttonCompose.Enabled = false;
				this.buttonCompose.Text = "Composing isn't supported on this device.";
			}
		}

		private void buttonCompose_Click(object sender, EventArgs e)
		{
			var recipients = this.tagTextBoxRecipients.Text.Split(',');

			Device.Sms.Compose(new Shared.Communication.SmsMessage
			{
				Recipients = new List<string>(recipients),
				Body = this.textBoxBody.Text
			});
		}

		public override bool IsSupported()
		{
			return Device.Valid && Device.Info.Sms.IsComposeSupported;
		}
	}
}
