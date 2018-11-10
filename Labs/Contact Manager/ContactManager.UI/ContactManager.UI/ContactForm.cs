// Carlos Fuentes
// 11/4/2018

using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace ContactManager.UI
{
	public partial class ContactForm : Form
	{
		public ContactForm()
		{
			InitializeComponent();
		}

		public Contact Contact { get; set; }

		private void ContactForm_Load(object sender, EventArgs e)
		{
			if (Contact != null)
			{
				_txtName.Text = Contact.Name;
				_txtEmailAddress.Text = Contact.EmailAddress;
			}
		}
		
		private void OnSave_Click(object sender, EventArgs e)
		{
			if (!ValidateChildren())
				return;

			var contact = new Contact() {
				Name = _txtName.Text,
				EmailAddress = _txtEmailAddress.Text,
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

		private void OnValidatingName(object sender, CancelEventArgs e)
		{
			var control = sender as TextBox;

			if (String.IsNullOrEmpty(control.Text))
			{
				_errors.SetError(control, "Name is required");
				e.Cancel = true;
			} else
				_errors.SetError(control, "");
		}

		private void OnValidatingEmail(object sender, CancelEventArgs e)
		{
			var control = sender as TextBox;

			if (String.IsNullOrEmpty(control.Text))
			{
				_errors.SetError(control, "Valid email is required");
				e.Cancel = true;
			}
			else
				_errors.SetError(control, "");
		}		
	}
}
