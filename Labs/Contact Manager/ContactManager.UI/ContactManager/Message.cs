// Carlos Fuentes
// 11/4/2018

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContactManager
{
    public class Message : IValidatableObject
    {

        //Contact Name
        public string MessageName
        {
            get { return _msgName ?? ""; }
            set { _msgName = value; }
        }
        private string _msgName = "";

        //Contact email address
        public string MessageEmailAddress
        {
            get { return _msgEmailAddress ?? ""; }
            set { _msgEmailAddress = value; }
        }
        private string _msgEmailAddress = "";

        //Contact name
        public string MessageSubject
        {
            get { return _msgSubject ?? ""; }
            set { _msgSubject = value; }
        }
        private string _msgSubject = "";

        //Message Content
        public string MessageContent
        {
            get { return _msgContent ?? ""; }
            set { _msgContent = value; }
        }
        private string _msgContent = "";


        //Validates email an dsubject line
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (String.IsNullOrEmpty(MessageEmailAddress))
                yield return new ValidationResult("Email is required.", new[] { nameof(MessageEmailAddress) });

            if (String.IsNullOrEmpty(MessageSubject))
                yield return new ValidationResult("Subject line is required.", new[] { nameof(MessageSubject) });
        }
    }
}
