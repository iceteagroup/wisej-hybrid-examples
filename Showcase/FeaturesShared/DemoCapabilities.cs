using System;
using Wisej.Web;

namespace Wisej.Hybrid.Features
{
	/// <summary>Checks availability without constructing a demo or its controls.</summary>
	internal static class DemoCapabilities
	{
		internal static bool IsFrameworkDesktop => Device.Valid && Device.System.Platform.ToString() == "WinForms";

		internal static bool IsSupported(Type type)
		{
			// The Framework host has an explicit set of desktop implementations.
			// Keep unsupported native demos disabled instead of presenting mobile APIs
			// as available just because this is a valid Hybrid session.
			if (IsFrameworkDesktop)
			{
				switch (type.Name)
				{
					case "DeviceInfo":
					case "Preferences":
					case "Storage":
					case "BarcodeScanner":
					case "DocumentScanner":
					case "Signature":
					case "PullToRefresh":
					case "iFrame":
					case "VideoViewer":
						return true;
					default:
						return false;
				}
			}

			if (type == typeof(global::FeaturesShared.Panels.Chat) ||
				type == typeof(global::FeaturesShared.Panels.SyncFlashlight))
				return Application.StartupUri.Host != "localhost";

			if (!Device.Valid)
				return false;

			if (type == typeof(Panels.Accelerometer)) return Device.Sensors.IsAccelerometerSupported;
			if (type == typeof(Panels.Barometer)) return Device.Sensors.IsBarometerSupported;
			if (type == typeof(Panels.Compass)) return Device.Sensors.IsCompassSupported;
			if (type == typeof(Panels.Gyroscope)) return Device.Sensors.IsGyroscopeSupported;
			if (type == typeof(Panels.Magnetometer)) return Device.Sensors.IsMagnetometerSupported;
			if (type == typeof(Panels.Contacts)) return Device.System.Platform != DevicePlatform.WinUI;
			if (type == typeof(Panels.Email)) return Device.Email.IsComposeSupported;
			if (type == typeof(Panels.Sms)) return Device.Sms.IsComposeSupported;
			if (type == typeof(Panels.MenuBar)) return Device.System.Idiom == DeviceIdiom.Desktop;
#if !WINDOWS
			if (type == typeof(Panels.DocumentScanner)) return Device.System.IsMobile;
#endif
			if (type == typeof(global::FeaturesShared.Panels.TextScanner))
				return Device.System.Platform == DevicePlatform.iOS || Device.System.Platform == DevicePlatform.Android;
			if (type == typeof(global::FeaturesShared.Panels.Window))
				return Device.System.Platform != DevicePlatform.iOS || Device.System.Idiom == DeviceIdiom.Tablet;

			return true;
		}

		internal static bool IsPinned(Type type)
		{
			return type == typeof(global::FeaturesShared.Panels.SyncFlashlight) && Application.Uri.Host != "localhost";
		}
	}
}
