using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FenTrue.Models;
using Xamarin.Forms;

namespace FenTrue.Helpers
{
    public class ValidationHelper : ValidationAttribute
    {
        
        public ValidationHelper()
        {
        }

        public override bool IsValid(object value)
        {
            var inputValue = value as string;
            var isValid = true;

            if (!string.IsNullOrEmpty(inputValue))
            {
                isValid = false;
                return isValid;
            }
            
            return isValid;
        }
    }
}
