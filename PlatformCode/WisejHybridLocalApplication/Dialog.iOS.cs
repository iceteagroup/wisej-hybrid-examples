using Microsoft.Maui.ApplicationModel;
using System;

namespace WisejHybridLocalApplication
{
	internal class Dialog
	{
		public static void ShowDialog(string title, string message, Action callback)
		{
			MainThread.InvokeOnMainThreadAsync(() =>
			{
				var alert = new UIKit.UIAlertController();
				alert.Title = title;
				alert.Message = message;
				alert.AddAction(UIKit.UIAlertAction.Create("OK", UIKit.UIAlertActionStyle.Default, (a) => callback?.Invoke()));
				Platform.GetCurrentUIViewController().PresentViewController(alert, true, null);
			});
		}
	}
}
