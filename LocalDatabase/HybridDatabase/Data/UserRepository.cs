using HybridDatabase.Models;

namespace HybridDatabase.Data
{
	public class UserRepository
	{
		private DataContext _context;

		/// <summary>
		/// Creates a new instance of <see cref="UserRepository"/> with the given <see cref="DataContext"/>.
		/// </summary>
		/// <param name="context">The data context.</param>
		public UserRepository(DataContext context)
		{
			this._context = context;

			this._context.Connection.CreateTable<User>();
		}

		/// <summary>
		/// Adds a new user to the local database.
		/// </summary>
		/// <param name="user">The user to add.</param>
		/// <returns>The number of rows added to the table.</returns>
		public int AddNewUser(User user)
		{
			var result = this._context.Connection.Insert(user);
			return result;
		}

		/// <summary>
		/// Deletes a given user.
		/// </summary>
		/// <param name="user">The user to delete.</param>
		/// <returns>The number of rows deleted.</returns>
		public int DeleteUser(User user) 
		{
			var result = this._context.Connection.Delete(user);
			return result;
		}

		/// <summary>
		/// Gets a list of all users in the local database.
		/// </summary>
		/// <returns>The list of users.</returns>
		public List<User> GetAllUsers()
		{
			var users = this._context.Connection.Table<User>().ToList();
			return users;
		}
	}
}
