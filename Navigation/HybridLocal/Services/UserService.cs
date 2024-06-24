using HybridLocal.Models;
using Newtonsoft.Json;
using System;
using Wisej.Hybrid;

namespace HybridLocal.Services
{
	public class UserService
	{
		private static string USER_KEY = "HYBRID_USER";

		public User? GetUser()
		{
			var json = Device.Preferences.Get(USER_KEY, "");
			return JsonConvert.DeserializeObject<User?>(json);
		}

		public User SetUser(string email, string password)
		{
			var user = new User { Email = email, Password = password };
			var json = JSON.Stringify(user, false);
			
			Device.Preferences.Set(USER_KEY, json);

			return user;
		}

		public bool ValidatePassword(string password)
		{
			// TODO: actual user password validation...
			var user = GetUser();

			return user == null || user.Password == password;
		}
	}
}
