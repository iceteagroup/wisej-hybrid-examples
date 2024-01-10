using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Wisej.Hybrid.Shared.Communication;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Media")]
	public partial class Email : TestBase
	{
		public Email()
		{
			InitializeComponent();
		}

		private void Email_Load(object sender, EventArgs e)
		{
			if (!Device.Email.IsComposeSupported)
			{
				this.buttonCompose.Enabled = false;
				this.buttonCompose.Text = "Composing isn't supported on this device.";
			}
		}

		private void buttonCompose_Click(object sender, EventArgs e)
		{
			var to = this.tagTextBoxTo.Text.Split(this.tagTextBoxTo.SeparatorChar);
			var cc = this.tagTextBoxCC.Text.Split(this.tagTextBoxCC.SeparatorChar);

			Device.Email.Compose(new EmailMessage
			{
				To = new List<string>(to),
				Cc = new List<string>(cc),
				Body = this.textBoxBody.Text,
				Subject = this.textBoxSubject.Text,
			});
		}

		public override bool IsSupported()
		{
			return Device.Valid && Device.Info.Email.IsComposeSupported;
		}
	}
}
