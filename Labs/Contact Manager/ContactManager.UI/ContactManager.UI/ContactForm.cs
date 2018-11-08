// Cesar Estrada
// November 5, 2018
// ITSE 1430 MW 5pm
// ContactForm.cs

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
		
		#region Event Handlers

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

			//IsValideEmail(control.Text);

			if (String.IsNullOrEmpty(control.Text))
			{
				_errors.SetError(control, "Valid email is required");
				e.Cancel = true; //IsValideEmail(control.Text)
			}
			else
				_errors.SetError(control, "");
		}

		//bool IsValideEmail(string source)		// where does this go maybe in message for
		//{
		//	try
		//	{
		//		new System.Net.Mail.MailAddress(source);
		//		return true;
		//	} catch
		//	{ };
		//	return false;
		//}

		#endregion
				
	}
}
