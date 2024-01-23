using Android.App;
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
				AlertDialog.Builder dialog = new AlertDialog.Builder(Platform.CurrentActivity);
				AlertDialog alert = dialog.Create();
				alert.SetTitle(title);
				alert.SetMessage(message);
				alert.SetCanceledOnTouchOutside(false);
				alert.SetButton("OK", (c, ev) => callback?.Invoke("OK"));
				alert.Show();
			});
		}
	}
}
