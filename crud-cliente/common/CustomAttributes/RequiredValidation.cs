using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace common.CustomAttributes
{
    public class RequiredValidation : ValidationAttribute
    {        
        private readonly Type _fieldType;

        public RequiredValidation(Type FieldType)
        {
            _fieldType = FieldType;            
        }


        public override bool IsValid(object value)
        {
            var inputValue = value.ToString();

            return !string.IsNullOrWhiteSpace(inputValue);                       
        }
    }
}
