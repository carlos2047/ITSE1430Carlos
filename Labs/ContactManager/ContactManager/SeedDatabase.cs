// Cesar Estrada
// November 5, 2018
// ITSE 1430 MW 5pm
// SeedDataBase.cs

namespace ContactManager
{
	/// <summary>Provides extensions for <see cref="ContactDatabase"/>.</summary>
	public static class ContactDatabaseExtensions
	{
		/// <summary>Seeds a database.</summary>
		/// <param name="source">The database to seed.</param>
		/// <remarks>
		/// Extension method to see a database.
		/// </remarks>
		public static void Seed ( this IContactDatabase source )
		{
			//var contacts = new[] {
			//	new Contact(){
			//		Name = "Test1",
			//		EmailAddress = "testemail1@gmail.com",
			//	},
			//	new Contact() {
			//	Name = "Test2",
			//	EmailAddress = "testemail2@gmail.com"
			//	},
			//};

			var contacts = new[] {
				new Contact(){
					Name = "Cesar Estrada",
					EmailAddress = "cesar.estrada585@my.tccd.edu",
				},				
			};

			Seed(source, contacts);				
		}

		/// <summary>Seeds a database.</summary>
		/// <param name="source">The database to seed.</param>
		/// <param name="contacts">The contacts to seed with.</param>
		/// <remarks>
		/// Extension method to see a database.
		/// </remarks>
		public static void Seed ( this IContactDatabase source, Contact[] contacts )
		{
			foreach (var contact in contacts)
				source.Add(contact);
		}
	}
}
