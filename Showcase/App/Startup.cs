using FeaturesOffline;
using Microsoft.Extensions.Logging;
using Wisej.Hybrid.Authentication.Native.Middleware;
using Wisej.Hybrid.DocumentScanner.Native;
#if !WINDOWS
using Wisej.Hybrid.MLKit.Native.Middleware;
#endif
using Wisej.Hybrid.Native.Core;

namespace HybridApp
{
	public static class Startup
	{
		public static MauiApp Main()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				})

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

#if DEBUG
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}