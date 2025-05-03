using BitBasket.Core.DTO;
using BitBasket.Core.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBasket.Core.Validator
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator() {
            RuleFor(prop => prop.Email)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Valid email address is required");

            RuleFor(prop => prop.Password)
                .NotEmpty().WithMessage("Password is required");

            RuleFor(prop => prop.PersonName)
                .NotEmpty().WithMessage("Person name is required")
                .Length(3, 50).WithMessage("Person name should be atleast 3 characters and not more than 50.");

            RuleFor(prop => prop.Gender)
              .IsInEnum()
              .WithMessage("Gender should Male, Female or Others");
        }
    }
}
