using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;

namespace CustomClassLibrary
{
    public class CustomerValidator: AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Поле не должно быть пустым!").MaximumLength(50).WithMessage("Поле превышает возможную длину");
            RuleFor(x => x.FirstName).MaximumLength(50).WithMessage("Поле превышает возможную длину");
            RuleFor(x => x.Addresses).NotNull().WithMessage("Список не должен быть пустым!");
            RuleFor(x => x.Notes).NotNull().WithMessage("Список не должен быть пустым!");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Введите корректный адрес электронной почты");
            RuleFor(x => x.Phone).Matches(@"^\+?[1-9]\d{1,14}$").WithMessage("Введите корректный номер телефона");
        }
        public List<string> ValidatorRun(Customer customer)
        {
            CustomerValidator validator = new();
            List<string> errors = new List<string>();
            ValidationResult result= validator.Validate(customer);
            if(!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {
                    errors.Add(failure.ErrorMessage);
                }
            }
            return errors;
        }

    }
   

    
  

}

