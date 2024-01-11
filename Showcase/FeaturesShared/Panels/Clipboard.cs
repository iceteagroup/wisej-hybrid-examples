using System;
using System.ComponentModel;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Input")]
	public partial class Clipboard : TestBase
	{
		public Clipboard()
		{
			InitializeComponent();
		}

		private void Clipboard_Appear(object sender, EventArgs e)
		{
			Device.Clipboard.ContentChanged += Clipboard_ContentChanged;
		}

		private void Clipboard_Disappear(object sender, EventArgs e)
		{
			Device.Clipboard.ContentChanged -= Clipboard_ContentChanged;
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
