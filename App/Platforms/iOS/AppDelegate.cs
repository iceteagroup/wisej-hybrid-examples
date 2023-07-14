using Foundation;
using Wisej.Hybrid.Native;

namespace App
{
	[Register("AppDelegate")]
	public class AppDelegate : HybridUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp() => Startup.Main();
	}
}