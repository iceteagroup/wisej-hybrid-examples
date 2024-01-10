using Wisej.Hybrid.Native.Controls;
using Wisej.Hybrid.Native.Core;

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