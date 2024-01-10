using HybridDatabase.Data;
using HybridDatabase.Models;
using HybridOffline.Views;
using System;
using System.Linq;
using Wisej.Services;
using Wisej.Web;

namespace HybridOffline
{
	public partial class MainPage : Page
	{
		[Inject]
		private UserRepository _userRepository { get; set; }

		private BindingSource _bindingSource = new BindingSource();

		public MainPage()
		{
			InitializeComponent();
		}

		private void MainPage_Load(object sender, EventArgs e)
		{
			this.dataGridView1.DataSource = this._bindingSource;

			RefreshDataSource();
		}

		private void RefreshDataSource()
		{
			this._bindingSource.DataSource = this._userRepository.GetAllUsers();
		}

		private void buttonDeleteRecord_Click(object sender, EventArgs e)
		{
			// get selected row and user.
			var record = this.dataGridView1.SelectedRows.FirstOrDefault();
			if (record == null)
				return;

			var user = (User)record.DataBoundItem;

			// delete user from db.
			this._userRepository.DeleteUser(user);

			// refresh data source.
			RefreshDataSource();
		}

		private void buttonAddRecord_Click(object sender, EventArgs e)
		{
			var addUserForm = new AddUserForm();
			if (addUserForm.ShowDialog() == DialogResult.OK)
			{
				this._userRepository.AddNewUser(addUserForm.User);
			}

			RefreshDataSource();
		}
	}
}
