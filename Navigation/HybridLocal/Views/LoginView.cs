using HybridLocal.Services;
using System.ComponentModel;
using Wisej.Hybrid;
using Wisej.Web;

namespace HybridLocal.Views
{
	public partial class LoginView : ViewBase
	{
		public LoginView()
		{
			InitializeComponent();
		}

		private void buttonLogin_Click(object sender, System.EventArgs e)
		{
			// save the email for the next login request.
			Device.Preferences.Set("email", this.textBoxEmail.Text);

			// TODO: perform some validation....

			// add a user service for this specific session.
			var service = new UserService 
			{
				Email = this.textBoxEmail.Text, 
				Password = this.textBoxPassword.Text 
			};

			Application.Services.AddService<UserService>(service, Wisej.Services.ServiceLifetime.Session);

			this.RequestView(typeof(HomeView));
		}

		private void LoginView_Load(object sender, System.EventArgs e)
		{
			this.textBoxEmail.Text = Device.Preferences.Get("email", "");
		}
	}
}
