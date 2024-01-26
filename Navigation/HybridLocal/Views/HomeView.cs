using HybridLocal.Services;
using Wisej.Services;
using Wisej.Web;

namespace HybridLocal.Views
{
	public partial class HomeView : ViewBase
	{
		[Inject()]
		private UserService _userService { get; set; }

		public HomeView()
		{
			InitializeComponent();
		}

		private void HomeView_Load(object sender, System.EventArgs e)
		{
			this.labelWelcome.Text = $"Welcome, {this._userService.Email}";
		}

		private void buttonLogin_Click(object sender, System.EventArgs e)
		{
			// logout.
			Application.Services.RemoveService(typeof(UserService));

			RequestView(typeof(LoginView));
		}
	}
}
