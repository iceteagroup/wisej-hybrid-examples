﻿using Android.App;
using Android.Content.PM;
using Wisej.Hybrid.Native;

namespace HybridApp
{
	[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
	public class MainActivity : HybridAppCompatActivity
	{
	}
}