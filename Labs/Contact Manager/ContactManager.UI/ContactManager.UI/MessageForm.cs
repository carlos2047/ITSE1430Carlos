// Cesar Estrada
// November 5, 2018
// ITSE 1430 MW 5pm
// SendMessage.cs

using ContactManager.Memory;
using System;
using System.Windows.Forms;

namespace ContactManager.UI
{
	public partial class MessageForm : Form 
	{
		public MessageForm()
		{
			InitializeComponent();
		}

		public Contact Contact { get; internal set; }
		public Message Message { get; private set; }

		private void MessageForm_Load(object sender, EventArgs e)
		{
			_txtName.Text = Contact.Name;
			_txtEmailAddress.Text = Contact.EmailAddress;
		}

		#region Event Handlers

		private void OnSend_Click(object sender, EventArgs e)
		{
			if (!ValidateChildren())
				return;

			//_txtEmailAddress.Text = Contact.EmailAddress; // you may not need

			var contact = new Contact()	{
				Name = _txtName.Text,
				EmailAddress = _txtMessage.Text,
				Subject = _txtSubject.Text,
				Message = _txtMessage.Text,				
			};

			var results = ObjectValidator.Validate(contact);
			foreach (var result in results)
			{
				MessageBox.Show(this, result.ErrorMessage, "Validation Failed",
							   MessageBoxButtons.OK);
				return;
			};

			Contact = contact;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void OnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		#endregion

		private void OnValidatingSubject(object sender, System.ComponentModel.CancelEventArgs e)
		{
			var control = sender as TextBox;

			if (String.IsNullOrEmpty(control.Text))
			{				
				_errors.SetError(control, "Subject is required");
				e.Cancel = true;
			}
			else
				_errors.SetError(control, "");
		}

		private IContactDatabase _database = new MemoryContactDatabase();

	}
}
