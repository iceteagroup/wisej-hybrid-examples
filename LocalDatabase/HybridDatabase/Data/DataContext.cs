using SQLite;

namespace HybridDatabase.Data
{
	public class DataContext : IDisposable
	{
		// sql lite db connection.
		internal SQLiteConnection Connection;

		public DataContext(string connectionString)
		{
			// Assuming the connection string is named "DefaultConnection" in your config file
			Connection = new SQLiteConnection(connectionString);
		}

		public void Dispose()
		{
			this.Connection?.Dispose();
		}
	}
}
