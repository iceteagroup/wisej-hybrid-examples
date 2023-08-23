using System;
using System.ComponentModel;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("UI")]
	public partial class Storage : TestBase
	{
		public Storage()
		{
			InitializeComponent();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			Device.FileSystem.WriteAppDataText("sample.txt", this.textBoxContents.Text);
		}

		private void Storage_Appear(object sender, EventArgs e)
		{
			this.textBoxContents.Text = Device.FileSystem.ReadAppDataText("sample.txt");
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			this.textBoxContents.Text = "";
			Device.FileSystem.WriteAppDataText("sample.txt", "");
		}
	}
}
