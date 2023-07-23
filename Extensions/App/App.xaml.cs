using Wisej.Hybrid.Native.Controls;

namespace App
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new HybridShell();
		}
	}
}