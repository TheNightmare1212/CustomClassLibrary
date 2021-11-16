using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClassLibrary
{
    public static class CustomerValidator
    {
        public static List<string> Validate(Customer customer)
        {
            var errorsList = new List<ValidationResult>();
            Validator.TryValidateObject(
                customer,
                new ValidationContext(customer),
                errorsList,
                true);

            var result = from error in errorsList
                         select error.ErrorMessage;

            return result.ToList();
        }
    }
    class RequiredString : ValidationAttribute
    {
        private string name = "";
        public override string FormatErrorMessage(string name)
        {
            this.name = name;
            return ErrorMessage;
        }
        public new string? ErrorMessage => $"Поле {name} обязательно";
        public override bool IsValid(object value)
        {
            if (value == null || (value as string) == String.Empty)
            {
                return false;
            }
            return true;
        }
       
    }
    class MaxChars : ValidationAttribute
    {
        private int maxLength = 0;
        public MaxChars(int maxLength)
        {
            this.maxLength = maxLength;
        }
        private string name = "";
        public override string FormatErrorMessage(string name)
        {
            this.name = name;
            return ErrorMessage;
        }
        public new string? ErrorMessage => $"Поле {name} превышает возможную длину ";
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }
            if (value.ToString().Length > maxLength)
            {
                return false;
            }
            return true;
        }
    }
    class NotEmptyList:ValidationAttribute
    {
        private string name = "";
        public override string FormatErrorMessage(string name)
        {
            this.name = name;
            return ErrorMessage;
        }
        public new string? ErrorMessage => $"Список {name} не должен быть пустым ";
        public override bool IsValid(object value)
        {
            
            if (value!=null)
            {
                return true;
            }
            if (value==null)
            {
                return false;
            }
            return true;
        }

    }
}
