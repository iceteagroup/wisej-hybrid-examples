
using Wisej.Hybrid.DocumentScanner.Native;
using Wisej.Hybrid.Native;
using WisejHybridLocalApplication;

namespace HybridClient
{
	public static class Startup
	{
		public static MauiApp Main()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()

				 // Uncomment and replace with Offline startup Type to use embedded web server.
				 .UseWisejOffline<OfflineStartup>()

				.UseWisejHybrid((config) =>
				{
					config.LicenseKey = "";

					// Provide the startup URL for the Hybrid WebView.
					config.StartupUrl = "http://localhost:5000";
				})
				
				.UseWisejDocumentScanner();

			return builder.Build();
		}
	}
}