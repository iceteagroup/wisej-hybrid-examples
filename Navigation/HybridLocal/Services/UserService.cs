using HybridLocal.Models;
using Newtonsoft.Json;
using Wisej.Hybrid;

namespace HybridLocal.Services
{
	/// <summary>
	/// Service class for managing user data and authentication.
	/// </summary>
	public class UserService
	{
		private static readonly string USER_KEY = "HYBRID_USER";

		/// <summary>
		/// Retrieves the stored user information from the device preferences.
		/// </summary>
		/// <returns>The deserialized <see cref="User"/> object, or null if not found.</returns>
		public User? GetUser()
		{
			var json = Device.Preferences.Get(USER_KEY, "");
			return JsonConvert.DeserializeObject<User?>(json);
		}

		/// <summary>
		/// Creates a new user with the specified email and password, and stores it in the device preferences.
		/// </summary>
		/// <param name="email">The email address of the user.</param>
		/// <param name="password">The password of the user.</param>
		/// <returns>The created <see cref="User"/> object.</returns>
		public User SetUser(string email, string password)
		{
			var user = new User { Email = email, Password = password };
			var json = JsonConvert.SerializeObject(user, Formatting.None);

			Device.Preferences.Set(USER_KEY, json);

			return user;
		}

		/// <summary>
		/// Validates the given password against the stored user's password.
		/// </summary>
		/// <param name="password">The password to validate.</param>
		/// <returns>True if the password is valid or if no user is stored; otherwise, false.</returns>
		public bool ValidatePassword(string password)
		{
			// TODO: Implement actual user password validation logic.
			var user = GetUser();
			return user == null || user.Password == password;
		}
	}
}
