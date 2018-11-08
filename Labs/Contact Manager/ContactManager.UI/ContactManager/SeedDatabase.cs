// Carlos Fuentes
// 11/4/2018

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
			var contacts = new[] {
				new Contact(){
					Name = "Carlos Fuentes",
					EmailAddress = "carlos.fuentes906@my.tccd.edu",
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
