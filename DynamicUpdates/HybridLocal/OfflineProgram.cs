using System;
using System.IO;
using System.Reflection;
using Wisej.Hybrid;
using Wisej.Web;

namespace HybridLocal
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			TryLoadOfflineApp();
			Application.ApplicationRefresh += Application_ApplicationRefresh;
		}

		private static void TryLoadOfflineApp()
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

		private static void LoadOfflineApp(string[] assemblies)
		{
			foreach (var path in assemblies)
			{
				try
				{
					var assembly = Assembly.LoadFrom(path);
					if (assembly.GetName().Name == "HybridShared")
					{
						_startupAssembly = assembly;
					}
				}
				catch (Exception ex)
				{
					AlertBox.Show(ex.Message);
				}
			}

			try
			{
				var program = _startupAssembly.GetType("HybridShared.Program");
				var mainMethod = program.GetMethod("Main", BindingFlags.Static | BindingFlags.NonPublic);
				mainMethod.Invoke(null, null);
			}
			catch (Exception ex)
			{
				AlertBox.Show(ex.Message);
			}
		}
		private static Assembly _startupAssembly;

		private static void Application_ApplicationRefresh(object sender, System.EventArgs e)
		{
			TryLoadOfflineApp();
		}
	}
}