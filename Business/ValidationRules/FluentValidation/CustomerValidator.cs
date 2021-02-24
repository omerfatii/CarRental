using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.CompanyName).MinimumLength(3);
            RuleFor(p => p.CompanyName).Must(FinishWithCom).WithMessage("Şirket İsmi .com 'la bitmeli");


        }

        private bool FinishWithCom(string arg)
        {
            return arg.EndsWith(".com");
        }
    }
}
