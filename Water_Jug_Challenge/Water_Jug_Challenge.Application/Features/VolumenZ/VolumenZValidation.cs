using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Water_Jug_Challenge.Application.Validation;
using Water_Jug_Challenge.Domain;

namespace Water_Jug_Challenge.Application.Features.VolumenZ
{
    public class VolumenZValidation
    {
        public VolumenZValidation(JugsZ validationJugs)
        {
            var Error = String.Empty;

            ValidationJugsZ validationRules = new ValidationJugsZ();
            var resul = validationRules.Validate(validationJugs);

            foreach (var values in resul.Errors)
            {
                Error = values.PropertyName + ":" + values.ErrorMessage;

            }
        }
    }
}
