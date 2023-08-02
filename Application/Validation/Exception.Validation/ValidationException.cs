using System;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validation.Exception.Validation
{
    public class ValidationException : ApplicationException
    {
        public List<string> Errors { get; set; } = new List<string>();
        public ValidationException(ValidationResult _validationResult)
        {
            foreach (var error in _validationResult.Errors)
            {
                Errors.Add(error.ErrorMessage);
            }

        }
    }
}
