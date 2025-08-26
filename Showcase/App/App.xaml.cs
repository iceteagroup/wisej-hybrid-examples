using Wisej.Hybrid.Native.Controls;
using Wisej.Hybrid.Native;

namespace HybridApp
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