using Application.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validation.Model.Validation
{
    public class NonAgriculturalDTOValidation : AbstractValidator<NonAgriculturalDTO>
    {


        public NonAgriculturalDTOValidation()
        {
            RuleFor(p => p.License)
                .NotEmpty().WithMessage("{PropertyName} is requiered.")
                .NotNull();
            RuleFor(p => p.Warehouse)
               .NotEmpty().WithMessage("{PropertyName} is requiered.")
               .NotNull();
        }
    }
}
