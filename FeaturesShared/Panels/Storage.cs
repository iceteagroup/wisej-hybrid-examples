using System;
using System.ComponentModel;
using System.IO;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("UI")]
	public partial class Storage : TestBase
	{
		private string _filePath;

		public Storage()
		{
			InitializeComponent();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			Device.FileSystem.WriteText(_filePath, this.textBoxContents.Text);
		}

		public override void Activate()
		{
			 this._filePath = Path.Combine(Device.Info.FileSystem.AppDataDirectory, "sample.txt");
		}

		private void Storage_Appear(object sender, EventArgs e)
		{
			if (File.Exists(_filePath)) 
				this.textBoxContents.Text = Device.FileSystem.ReadText(_filePath);
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			this.textBoxContents.Text = "";
			Device.FileSystem.DeleteFile(_filePath);
		}
	}
}
