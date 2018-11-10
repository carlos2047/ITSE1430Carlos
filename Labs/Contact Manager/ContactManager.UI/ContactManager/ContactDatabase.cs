// Carlos Fuentes
// 11/4/2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
	/// <summary>Manages a set of contacts.</summary>
	public abstract class ContactDatabase : IContactDatabase
	{
		/// <summary>Adds a contact to the database.</summary>
		/// <param name="contact">The contact to add.</param>
		public void Add(Contact contact)
		{
			if (contact == null)
				return;

			AddCore(contact);
		}

        public abstract void Send(string emailAddress, string subject, string message);

        //internal abstract void AddCore(string emailAddress, string subject, string message);

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

            EditCore(FindByName(name),contact);
		}

		/// <summary>Removes a contact.</summary>
		/// <param name="name">The contact to remove.</param>
		public void Remove(string name)
		{
			if (String.IsNullOrEmpty(name))
				return;

			RemoveCore(name);
		}

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
	}
}
