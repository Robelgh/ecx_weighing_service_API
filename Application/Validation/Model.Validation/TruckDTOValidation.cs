using Application.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validation.Model.Validation
{
    public class TruckDTOValidation : AbstractValidator<TruckDTO>
    {
        public TruckDTOValidation()
        {
            RuleFor(p => p.Trucktype)
                .NotEmpty().WithMessage("{PropertyName} is requiered.")
                .NotNull();

        }
    }
}
