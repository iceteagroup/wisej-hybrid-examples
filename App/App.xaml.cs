using Wisej.Hybrid.Native.Controls;
using Wisej.Hybrid.Native.Core;

namespace HybridApp
{
	public partial class App : Application
	{
		public App()
		{
			try
			{
				InitializeComponent();

				MainPage = new HybridShell();
			}
			catch (Exception ex) 
			{ 
				Wisej.Hybrid.Native.Core.App.Log(ex);
			}
		}
	}
}