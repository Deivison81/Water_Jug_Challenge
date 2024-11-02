using FluentValidation.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Water_Jug_Challenge.Application.Validation;
using Water_Jug_Challenge.Domain;

namespace Water_Jug_Challenge.Application.Features.CapacityX
{
    public class CapacityXValidation
    {

        public CapacityXValidation(JugsX validationJugs)
        {
            var Error = String.Empty;
            
            ValidationJugsX validationRules = new ValidationJugsX();
            var resul = validationRules.Validate(validationJugs);

            foreach (var values in resul.Errors)
            {
                Error = values.PropertyName + ":" + values.ErrorMessage;
                 
            }
            
        }
        
    }
}
