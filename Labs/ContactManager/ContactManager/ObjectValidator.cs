// Cesar Estrada
// November 5, 2018
// ITSE 1430 MW 5pm
// ObjectValidator.cs

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContactManager
{
	/// <summary>Provides support for validating objects.</summary>
	public static class ObjectValidator
	{
		// <summary>Validates an object.</summary>
		/// <param name="value">The object to validate.</param>
		/// <returns>The list of validation results.</returns>
		public static IEnumerable<ValidationResult> Validate(IValidatableObject value)
		{
			var results = new List<ValidationResult>();

			var context = new ValidationContext(value);

			Validator.TryValidateObject ( value, context, results, true );

			return results;
		}

	}
}
