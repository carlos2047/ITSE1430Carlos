// Carlos Fuentes
// 11/4/2018

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

		public Contact Contact { get; set; }
		public Message Message { get; set; }

		private void MessageForm_Load(object sender, EventArgs e)
        {
            if (Contact != null)
            {
                _txtName.Text = Contact.Name;
                _txtEmailAddress.Text = Contact.EmailAddress;
            }

            if (Message != null)
            {
                _txtName.Text = Message.MessageName;
                _txtEmailAddress.Text = Message.MessageEmailAddress;
            }

            ValidateChildren();
        }

        private void OnSend_Click(object sender, EventArgs e)
		{
			if (!ValidateChildren())
				return;

            var message = new Message()
            {
                MessageName = _txtName.Text,
                MessageEmailAddress = _txtEmailAddress.Text,
                MessageSubject = _txtSubject.Text,
                MessageContent = _txtMessage.Text,
            };

            var results = ObjectValidator.Validate(message);
			foreach (var result in results)
			{
				MessageBox.Show(this, result.ErrorMessage, "Validation Failed",
							   MessageBoxButtons.OK);
				return;
			};

			Message = message;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void OnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

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
