using System;
using System.ComponentModel;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Input")]
	public partial class Clipboard : TestBase
	{
		public Clipboard()
		{
			InitializeComponent();

			Device.Clipboard.ContentChanged += Clipboard_ContentChanged;
		}

		private void Clipboard_ContentChanged(object sender, EventArgs e)
		{
			this.labelClipboard.Text = Device.Clipboard.GetText();
		}

		private void buttonRead_Click(object sender, EventArgs e)
		{
			this.labelClipboard.Text = Device.Clipboard.GetText();
		}

		private void buttonSet_Click(object sender, EventArgs e)
		{
			Device.Clipboard.SetText(this.textBoxClipboard.Text);
		}
	}
}
