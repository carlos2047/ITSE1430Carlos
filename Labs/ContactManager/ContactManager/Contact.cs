// Cesar Estrada
// November 5, 2018
// ITSE 1430 MW 5pm
// Contact.cs

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContactManager
{
	public class Contact : IValidatableObject
	{
		// Property to back the name field
		public string Name
		{
			get => _name ?? "";
			set => _name = value;
		}
		// Backing field for name
		private string _name = "";

		// Property to back the email address field
		public string EmailAddress
		{
			get => _emailAddress ?? "";
			set => _emailAddress = value;
		}
		// Backing field for email address
		private string _emailAddress;

		// Property to back the subject field
		public string Subject
		{
			get => _subject ?? "";
			set => _subject = value;
		}
		// Backing field for subject
		private string _subject;

		// Property to back the message field
		public string Message
		{
			get => _message ?? "";
			set => _message = value;
		}
		// Backing field for message
		private string _message;


		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if (String.IsNullOrEmpty(Name))
				yield return new ValidationResult("Name is required.", new[] { nameof(Name) });

			//if (String.Distinct().Count != String.Count())
			//	yield return new ValidationResult("Valid is required.", new[] { nameof(EmailAddress) });

			if (String.IsNullOrEmpty(EmailAddress))
				yield return new ValidationResult("Email is required.", new[] { nameof(EmailAddress) });

			if (String.IsNullOrEmpty(Subject))
				yield return new ValidationResult("Subject is required.", new[] { nameof(Subject) });
		}
	}
	
}
