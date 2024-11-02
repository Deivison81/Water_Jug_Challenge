using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Water_Jug_Challenge.Application.Validation;
using Water_Jug_Challenge.Domain;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Water_Jug_Challenge.Application.Exception
{
    public class ValidationException : ApplicationException
    {
        public ValidationException() : base("se presentaron uno o mas errores de validacion")
        {
            Errors = new Dictionary<string, string[]>();
        }

        public ValidationException(IEnumerable<ValidationFailure> failures) : this()
        {
            Errors = failures
                .GroupBy(e => e.PropertyName, e => e.ErrorMessage)
                .ToDictionary(failuresGroup => failuresGroup.Key, failuresGroup => failuresGroup.ToArray());
        }
        public IDictionary<string, string[]> Errors { get; }

    }
}
