// Carlos Fuentes
// 11/4/2018

using ContactManager.Memory;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ContactManager.UI
{
	public partial class MainForm : Form
    {
		public MainForm()
		{
			InitializeComponent();
		}

		protected override void OnLoad ( EventArgs e )
		{
			base.OnLoad(e);

			_listContacts.DisplayMember = "Name";
			_listMessages.DisplayMember = "MessageSubject";

            RefreshContacts();
            RefreshMessages();
        }


		private void OnFileExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to exit the Contact Manager?",
					"Close", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
				return;

			Close();
		}

		private void OnContactNew_Click(object sender, EventArgs e)
		{
			var form = new ContactForm();
			if (form.ShowDialog(this) == DialogResult.Cancel)
				return;

			_database.Add(form.Contact);
			RefreshContacts();
		}

        private void OnSendMessage_Click(object sender, EventArgs e)
        {
            // Get selected name, if any
            var item = GetSelectedContact();
            if (item == null)
                return;

            var form = new MessageForm();
            form.Contact = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

             _sentMessages.Send(form.Message);

            _sentMessages.GetAll();
            RefreshMessages();
        }

        private void OnContactEdit_Click(object sender, EventArgs e)
		{
			EditContact();
		}

		private void OnContactDelete_Click(object sender, EventArgs e)
		{
			DeleteContact();
		}

		private void OnHelpAbout_Click(object sender, EventArgs e)
		{
			MessageBox.Show(this, "Carlos Fuentes\n ITSE 1430\n Contact Manager",
				"About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void OnContactDoubleClick(object sender, EventArgs e)
		{
			EditContact();
		}

        private void OnListKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Delete)
			{
				DeleteContact();
			}
		}
        
		private void DeleteContact ()
		{
			// Get selected name, if any
			var itemName = GetSelectedContact();
			if (itemName == null)
				return;

			// Show form with selected name
			var form = new ContactForm();
			form.Contact = itemName;

			if (MessageBox.Show($"Are you sure you want to delete {itemName.Name}?", "Delete Contact",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				return;

			//Get selected contact, if any
			var item = GetSelectedContact();
			if (item == null)
				return;

			// Remove from database and refresh
			_database.Remove(item.Name);
			RefreshContacts();
		}

		private void EditContact ()
		{
			//Get selected contact, if any
			var item = GetSelectedContact();
			if (item == null)
				return;

			//Show form with selected contact
			var form = new ContactForm();
			form.Contact = item;
			if (form.ShowDialog(this) == DialogResult.Cancel)
				return;

			//Update database and refresh
			_database.Edit(item.Name, form.Contact);
			RefreshContacts();
		}

		private void RefreshContacts()
		{
			var contacts = from m in _database.GetAll()
						   orderby m.Name
						   select m;			

			_listContacts.Items.Clear();
			_listContacts.Items.AddRange(contacts.ToArray());
		}

        private void RefreshMessages()
        {
            var messages = from m in _sentMessages.GetAll()
                           select m;

            _listMessages.Items.Clear();
            _listMessages.Items.AddRange(messages.ToArray());
        }

        private Contact GetSelectedContact()
		{
			return _listContacts.SelectedItem as Contact;
		}

        private Message GetSelectedMessage()
        {
            return _listMessages.SelectedItem as Message;
        }


        private IContactDatabase _database = new MemoryContactDatabase();
        private IMessageService _sentMessages = new MemoryMessageDatabase();

        private void Format(object sender, ListControlConvertEventArgs e)
        {
            string email = ((Message)e.ListItem).MessageEmailAddress.ToString();
            string subject = ((Message)e.ListItem).MessageSubject.ToString();
            string message = ((Message)e.ListItem).MessageContent.ToString();

            e.Value = email + ", RE: " + subject + " Message: " + message;
        }
    }
}
