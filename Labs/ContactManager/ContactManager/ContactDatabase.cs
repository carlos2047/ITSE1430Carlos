// Cesar Estrada
// November 5, 2018
// ITSE 1430 MW 5pm
// ContactDatabase.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
	/// <summary>Manages a set of contacts.</summary>
	public abstract class ContactDatabase : IContactDatabase, IMessageService
	{
		/// <summary>Adds a contact to the database.</summary>
		/// <param name="contact">The contact to add.</param>
		public void Add(Contact contact)
		{
			if (contact == null)
				return;

			AddCore(contact);
		}

		/// <summary>Gets all the contacts.</summary>
		/// <returns>The list of contacts.</returns>
		public IEnumerable<Contact> GetAll()
		{
			return GetAllCore();
		}

		/// <summary>Edits an existing contact.</summary>
		/// <param name="name">The contact to edit.</param>
		/// <param name="contact">The new contact.</param>
		public void Edit(string name, Contact contact)
		{
			if (String.IsNullOrEmpty(name))
				return;
			if (contact == null)
				return;

			var existing = FindByName(name);
			if (existing == null)
				return;
		}

		/// <summary>Removes a contact.</summary>
		/// <param name="name">The contact to remove.</param>
		public void Remove(string name)
		{
			if (String.IsNullOrEmpty(name))
				return;

			RemoveCore(name);
		}

		#region Protected Members

		/// <summary>Adds a contact.</summary>
		/// <param name="contact">The contact to add.</param>
		protected abstract void AddCore(Contact contact);

		/// <summary>Edits a contact.</summary>
		/// <param name="oldContact">The old contact.</param>
		/// <param name="newContact">The new contact.</param>
		protected abstract void EditCore(Contact oldContact, Contact newContact);

		/// <summary>Finds a contact by name.</summary>
		/// <param name="name">The name of the contact.</param>
		/// <returns>The contact, if any.</returns>
		protected abstract Contact FindByName(string name);

		/// <summary>Gets all the contacts.</summary>
		/// <returns>The list of contacts.</returns>
		protected abstract IEnumerable<Contact> GetAllCore();

		/// <summary>Gets all the contacts.</summary>
		/// <returns>The list of contacts.</returns>
		protected abstract void RemoveCore(string name);
		#endregion
	}
}
