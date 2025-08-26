using FeaturesOffline;

using Wisej.Hybrid.Authentication.Native;
using Wisej.Hybrid.DocumentScanner.Native;
#if !WINDOWS
using Wisej.Hybrid.MLKit.Native;
using Wisej.Hybrid.MLKit.Native.Middleware;

#endif
using Wisej.Hybrid.Native;

namespace HybridApp
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
					config.StartupUrl = "http://localhost:5000/";
				})

#if !WINDOWS
				.UseWisejMLKit()
#endif
				.UseWisejAuthentication()
				.UseWisejDocumentScanner();

			return builder.Build();
		}
	}
}