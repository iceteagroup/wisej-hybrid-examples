using HybridLocal;
using Wisej.Hybrid.Native;

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
					// Uncomment to provide an offline fallback timeout.
					// config.OfflineTimeout = 5000;

					// Provide the startup URL for the Hybrid WebView.
					config.StartupUrl = "http://localhost:5001";
				});

			return builder.Build();
		}
	}
}