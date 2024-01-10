using SQLite;

namespace HybridDatabase.Models
{
	[Table("user")]
	public class User
	{
		public User() {}

		public User(string firstName, string lastName, bool isRegistered, DateTime startDate)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.IsRegistered = isRegistered;
			this.StartDate = startDate;
		}

		// PrimaryKey is typically numeric 
		[PrimaryKey, AutoIncrement, Column("_id")]
		public int Id { get; set; }

		[MaxLength(250)]
		public string FirstName { get; set; }

		[MaxLength(250)]
		public string LastName { get; set; }

		public bool IsRegistered { get; set; }

		public DateTime StartDate { get; set; }
	}
}
