using FeaturesOffline;
using Microsoft.Extensions.Logging;
using Wisej.Hybrid.Native.Core;

namespace App
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

				 // Uncomment when registering AppBuilderExtenders as part of a separate class library.
				 //.UseWisejExtenders()

				.UseWisejHybrid((config) =>
				{
					// Uncomment to provide an offline fallback timeout.
					// config.OfflineTimeout = 5000;

					// Provide the startup URL for the Hybrid WebView.
					config.StartupUrl = "http://localhost:5000";
				});

#if DEBUG
		builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}