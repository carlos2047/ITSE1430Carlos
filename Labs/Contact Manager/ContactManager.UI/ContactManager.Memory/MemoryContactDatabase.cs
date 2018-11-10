// Carlos Fuentes
// 11/4/2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
        /// <param name="name">The contact to edit.</param>
        /// <param name="contact">The new contact.</param>
        protected override void EditCore(Contact oldContact, Contact newContact)
        {
            _items.Remove(oldContact);
            _items.Add(newContact);
        }

        /// <summary>Removes a contact.</summary>
        /// <param name="name">The contact to remove.</param>
        protected override void RemoveCore(string name)
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
            return (from m in _items
                    where String.Compare(name, m.Name, true) == 0
                    select m).FirstOrDefault();
        }

        public override void Send(string emailAddress, string subject, string message) => _items.Add(contact);

        //internal override void AddCore(string emailAddress, string subject, string message) => _items.Add(message);



        private List<Contact> _items = new List<Contact>();

        public Contact contact { get; private set; }
       //public Message message { get; internal set; }

    }
}






