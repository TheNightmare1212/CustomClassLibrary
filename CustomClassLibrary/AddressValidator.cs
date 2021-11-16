using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClassLibrary
{
    public class AddressValidator
    {
        public static List<string> Validate(Address address)
        {
            var errorsList = new List<ValidationResult>();
            Validator.TryValidateObject(
                address,
                new ValidationContext(address),
                errorsList,
                true);

            var result = from error in errorsList
                         select error.ErrorMessage;

            return result.ToList();
        }
    }
}
