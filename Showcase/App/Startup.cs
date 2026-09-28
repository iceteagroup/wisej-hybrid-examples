using FeaturesOffline;
using Wisej.Hybrid.Authentication.Native;
using Wisej.Hybrid.Native;
using Wisej.Hybrid.MLKit.Native.Middleware;
#if !WINDOWS
using Wisej.Hybrid.DocumentScanner.Native;
#endif

namespace HybridApp
{
    public static class Startup
    {
        public static MauiApp Main()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseWisejOffline<OfflineStartup>()
                .UseWisejHybrid(config =>
                {
                    config.LicenseKey = "";
                    config.StartupUrl = "http://localhost:5000/";
                })
                .UseWisejAuthentication();

            builder.UseWisejMLKit();
#if !WINDOWS
            builder.UseWisejDocumentScanner();
#endif

            return builder.Build();
        }
    }
}