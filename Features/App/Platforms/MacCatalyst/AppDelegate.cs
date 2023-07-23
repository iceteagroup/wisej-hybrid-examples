using Foundation;

namespace App
{
	[Register("AppDelegate")]
	public class AppDelegate : MauiUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp() => Startup.Main();
	}
}