using Wisej.Services;
using Wisej.Web;

namespace HybridLocal.Views
{
	public partial class HomeView : ViewBase
	{
		public HomeView()
		{
			InitializeComponent();
		}

		private void HomeView_Load(object sender, System.EventArgs e)
		{
			var user = this.UserService.GetUser();
			this.labelWelcome.Text = $"Welcome, {user.Email}";
		}

		private void buttonLogin_Click(object sender, System.EventArgs e)
		{
			TryPopToView(typeof(LoginView));
		}
	}
}
