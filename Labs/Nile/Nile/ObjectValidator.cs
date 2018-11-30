// Carlos Fuentes
// ITSE 1430
// November 23, 2018
// ObjectValidator.cs

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile
{
	/// <summary>Provides support for validating objects.</summary>
	public static class ObjectValidator
	{

		/// <summary>Validates an object.</summary>
		/// <param name="value">The object to validate.</param>
		/// <returns>The list of validation results.</returns>
		public static IEnumerable<ValidationResult> TryValidate ( IValidatableObject value )
		{
			var results = new List<ValidationResult>();
			var context = new ValidationContext(value);
			Validator.TryValidateObject(value, context, results, true);
			return results;
		}

	}
}
