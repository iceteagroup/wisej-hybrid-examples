using Microsoft.Maui.ApplicationModel;
using System;

namespace WisejHybridLocalApplication
{
	internal class Dialog
	{
		public static void ShowDialog(string title, string message, Action<string> callback)
		{
			MainThread.InvokeOnMainThreadAsync(() =>
			{
				var alert = new UIKit.UIAlertController
				{
					Title = title,
					Message = message
				};
				alert.AddAction(UIKit.UIAlertAction.Create("OK", UIKit.UIAlertActionStyle.Default, (_) => callback?.Invoke("OK")));
				Platform.GetCurrentUIViewController().PresentViewController(alert, true, null);
			});
		}
	}
}
