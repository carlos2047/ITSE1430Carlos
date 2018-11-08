// Cesar Estrada
// November 5, 2018
// ITSE 1430 MW 5pm
// MemoryContactDataBase.cs

using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactManager.Memory
{
	/// <summary>Manages a set of contacts.</summary>
	public class MemoryContactDatabase : ContactDatabase
	{
		/// <summary>Adds a contact to the database.</summary>
		/// <param name="contact">The movie to add.</param>
		protected override void AddCore(Contact contact) => _items.Add(contact);

		/// <summary>Gets all the contacts.</summary>
		/// <returns>The list of contacts.</returns>
		protected override IEnumerable<Contact> GetAllCore()
		{
			//Use LINQ to clone movies
			return from item in _items
					   //where 
				   select new Contact()
				   {
						Name = item.Name,
						EmailAddress = item.EmailAddress,
						Subject = item.Subject,
						Message = item.Message,
				   };						          
		}

		/// <summary>Edits an existing contact.</summary>
		/// <param name="name">The movie to edit.</param>
		/// <param name="contact">The new contact.</param>
		protected override void EditCore ( Contact oldContact, Contact newContact )
		{
			_items.Remove(oldContact);
			_items.Add(newContact);
		}

		/// <summary>Removes a contact.</summary>
		/// <param name="name">The contact to remove.</param>
		protected override void RemoveCore ( string name )
		{
			var contact = FindByName(name);
			if (contact != null)
				_items.Remove(contact);
		}

		/// <summary>Finds a contact by its name.</summary>
		/// <param name="name">The name of the contact.</param>
		/// <returns>The contact, if any.</returns>
		protected override Contact FindByName(string name)
		{
			//return _items.FirstOrDefault(m => String.Compare(name, m.Name, true) == 0);

			//SQL syntax
			return (from m in _items
					where String.Compare(name, m.Name, true) == 0
					select m).FirstOrDefault();
		}

		#region Private Members

		private List<Contact> _items = new List<Contact>();
		#endregion
	}
}


		

