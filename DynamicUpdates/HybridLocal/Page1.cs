using System;
using System.IO;
using System.Reflection;
using Wisej.Hybrid;
using Wisej.Web;

namespace HybridLocal
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void Page1_Appear(object sender, EventArgs e)
		{
			// determine if an offline version of the app is available.
			var assembliesPath = Path.Combine(Device.Info.FileSystem.CacheDirectory, "Dlls");

			// if it is, load it.
			if (Directory.Exists(assembliesPath))
			{
				var assemblies = Directory.GetFiles(assembliesPath);

				LoadOfflineApp(assemblies);
			}
			else
			{
				// otherwise load the online version.
				Application.Navigate("https://wnk7f1wz-5000.use.devtunnels.ms/");
			}
		}

		private void LoadOfflineApp(string[] assemblies)
		{
			foreach (var path in assemblies)
			{
				try
				{
					var assembly = Assembly.LoadFrom(path);
					if (assembly.GetName().Name == "HybridRemote")
					{
						this._startupAssembly = assembly;
					}
				}
				catch (Exception ex)
				{
					AlertBox.Show(ex.Message);
				}
			}

			try
			{
				var program = this._startupAssembly.GetType("HybridRemote.Program");
				var mainMethod = program.GetMethod("Main", BindingFlags.Static | BindingFlags.NonPublic);
				mainMethod.Invoke(null, null);
			}
			catch (Exception ex)
			{
				AlertBox.Show(ex.Message);
			}
		}
		private Assembly _startupAssembly;
	}
}
