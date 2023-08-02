using Application.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validation.Model.Validation
{
    public class AgriculturalDTOValidation : AbstractValidator<AgriculturalDTO>
    {

       
        public AgriculturalDTOValidation()
        {
            RuleFor(p => p.Commodity)
                .NotEmpty().WithMessage("{PropertyName} is requiered.")
                .NotNull();
            RuleFor(p => p.Consignment)
               .NotEmpty().WithMessage("{PropertyName} is requiered.")
               .NotNull();
        }


    }
}
