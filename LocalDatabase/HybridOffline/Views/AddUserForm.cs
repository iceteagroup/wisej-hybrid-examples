using HybridDatabase.Models;
using Wisej.Web;

namespace HybridOffline.Views
{
	public partial class AddUserForm : Form
	{
		public User User
		{
			get
			{
				return new User
				{
					FirstName = this.textBoxFirst.Text,
					LastName = this.textBoxLast.Text,
					IsRegistered = this.checkBoxIsRegistered.Checked,
					StartDate = this.dateTimePickerStart.Value,
				};
			}
		}
		public AddUserForm()
		{
			InitializeComponent();
		}

		private void buttonAdd_Click(object sender, System.EventArgs e)
		{
			if (this.ValidateChildren())
			{
				this.Close();
			}
		}

		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
