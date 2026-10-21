using Wisej.Web;

namespace WisejHybridLocalApplication
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void buttonModelName_Click(object sender, System.EventArgs e)
		{
			string modelName = "";

#if ANDROID
			modelName = Android.OS.Build.Model;
#elif IOS
			modelName = UIKit.UIDevice.CurrentDevice.Model;
#elif NETFRAMEWORK
			modelName = Wisej.Hybrid.Device.System.Model;
#endif

			AlertBox.Show(modelName);
		}

		private void buttonNativeDialog_Click(object sender, System.EventArgs e)
		{
#if ANDROID || IOS
			Dialog.ShowDialog("Welcome", "Hello!", (r) => {
				Application.Update(this, () => AlertBox.Show($"Dialog closed: {r}"));
			});
#elif NETFRAMEWORK
			Wisej.Hybrid.Device.Popups.DisplayAlert("Welcome", "Hello!", "OK");
#endif
		}
	}
}