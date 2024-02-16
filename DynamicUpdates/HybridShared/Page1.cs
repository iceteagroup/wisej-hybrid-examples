using System.IO;
using Wisej.Hybrid;
using Wisej.Web;

namespace HybridShared
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void buttonMakeAvailableOffline_Click(object sender, System.EventArgs e)
		{
			AlertBox.Show("Downloading application...");

			var assemblies = Directory.GetFiles(Application.MapPath("../HybridShared/bin/Debug/net8.0-ios"), "*.dll");
			var cacheDirectory = Device.Info.FileSystem.CacheDirectory;
			var targetDirectory = $"{cacheDirectory}/Dlls";

			Application.ShowLoader = true;

			Device.FileSystem.CreateDirectory(targetDirectory);

			foreach (var file in assemblies)
			{
				var targetPath = $"{targetDirectory}/{Path.GetFileName(file)}";
				Device.FileSystem.WriteBytes(targetPath, File.ReadAllBytes(file));
			}

			Application.Navigate("http://localhost:5001");
		}

		private void Page1_Load(object sender, System.EventArgs e)
		{
			if (Application.StartupUri.Host == "localhost")
			{
				this.buttonMakeAvailableOffline.Enabled = false;
				this.labelStartup.Text = $"App is OFFLINE";
			}
		}
	}
}
