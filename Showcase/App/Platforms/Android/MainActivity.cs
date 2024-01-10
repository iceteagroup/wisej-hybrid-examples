﻿using Android.App;
using Android.Content.PM;
using Wisej.Hybrid.Native;

namespace HybridApp
{
	[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
	[IntentFilter(new[] { Platform.Intent.ActionAppAction },
			  Categories = new[] { global::Android.Content.Intent.CategoryDefault })]
	public class MainActivity : HybridAppCompatActivity
	{
		protected override void OnResume()
		{
			base.OnResume();

			Platform.OnResume(this);
		}

		protected override void OnNewIntent(Android.Content.Intent intent)
		{
			base.OnNewIntent(intent);

			Platform.OnNewIntent(intent);
		}
	}
}