using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Water_Jug_Challenge.Application.Validation;
using Water_Jug_Challenge.Domain;

namespace Water_Jug_Challenge.Application.Features.CapacityY
{
    public class CapacityYValidation
    {
        public CapacityYValidation(JugsY validationJugs)
        {
            var Error = String.Empty;

            ValidationJugsY validationRules = new ValidationJugsY();
            var resul = validationRules.Validate(validationJugs);

            foreach (var values in resul.Errors)
            {
                Error = values.PropertyName + ":" + values.ErrorMessage;

            }
        }
    }
}
