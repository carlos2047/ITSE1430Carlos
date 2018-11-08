// Cesar Estrada
// November 5, 2018
// ITSE 1430 MW 5pm
// ICMessageService.cs

using System.Collections.Generic;

namespace ContactManager
{
	/// <summary>Provides services for sending messages.</summary>
	public interface IMessageService
	{

		/// <summary>Adds a contact to the database.</summary>
		/// <param name="contact">The contact to add.</param>
		void Add(Contact contact);

		/// <summary>Sends a message.</summary>
		void Send(string emailAddress, string subject, string message);

		/// <summary>Gets all the movies.</summary>
		/// <returns>The list of movies.</returns>
		IEnumerable<Movie> GetAll();
	}
}
