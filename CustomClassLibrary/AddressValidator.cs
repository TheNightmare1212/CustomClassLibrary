using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;


namespace CustomClassLibrary
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Line).NotEmpty().WithMessage("Поле не должно быть пустым!").MaximumLength(100).WithMessage("Поле превышает возможную длину");
            RuleFor(x => x.Line2).MaximumLength(100).WithMessage("Поле превышает возможную длину");
            RuleFor(x => x.PostalCode).NotEmpty().WithMessage("Поле не должно быть пустым!").MaximumLength(6).WithMessage("Поле превышает возможную длину");
            RuleFor(x => x.State).NotEmpty().WithMessage("Поле не должно быть пустым!").MaximumLength(50).WithMessage("Поле превышает возможную длину");
            RuleFor(x => x.City).NotEmpty().WithMessage("Поле не должно быть пустым!").MaximumLength(20).WithMessage("Поле превышает возможную длину");
            RuleFor(x => x.Country).NotEmpty().WithMessage("Поле не должно быть пустым!").Must(BeAValidCountry).WithMessage("Возможные страны:США и Канада");
        }
        public bool BeAValidCountry(string country)
        {
            if (country == "Canada" || country == "USA")
            {
                return true;
            }
            else return false;
        }
        public List<string> ValidatorRun(Address address)
        {
            AddressValidator validator = new();
            List<string> errors = new List<string>();
            ValidationResult result = validator.Validate(address);
            if (!result.IsValid)
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
