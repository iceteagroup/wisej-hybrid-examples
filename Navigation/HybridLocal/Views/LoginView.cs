using HybridLocal.Models;

namespace HybridLocal.Views
{
	public partial class LoginView : ViewBase
	{
		private User User { get; set; }

		public LoginView()
		{
			InitializeComponent();
		}

		private void buttonLogin_Click(object sender, System.EventArgs e)
		{
			var email = this.textBoxEmail.Text;
			var password = this.textBoxPassword.Text;
			
			// create the user?
			if (this.User == null)
				this.User = this.UserService.SetUser(email, password);

			// validate the password.
			this.UserService.ValidatePassword(password);

			this.TryPushView(typeof(HomeView));
		}

		private void LoginView_Load(object sender, System.EventArgs e)
		{
			// get an existing saved user and populate fields.
			var user = this.UserService.GetUser();
			if (user != null)
			{
				this.textBoxEmail.Text = user.Email;
				this.textBoxPassword.Text = user.Password;
			}
			else
			{
				this.buttonLogin.Text = "Signup";
			}

			this.User = user;
		}
	}
}
