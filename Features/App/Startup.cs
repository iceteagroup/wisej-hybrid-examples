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

					// Uncomment to provide an action that can transform the device response
					// before sending it to the server.
					//config.FormatResponse += (response) =>
					//{
					//	switch (response.Handler) 
					//	{
					//		case "media":
					//			var base64 = response.Data;

					//			// apply custom compression.
					//			var compressed = CompressData(base64);

					//			response.Data = compressed;
					//			break;
					//	}
					//};

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