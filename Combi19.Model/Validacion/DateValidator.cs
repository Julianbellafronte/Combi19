using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Model.Validacion
{
    public class DateValidator: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime transactionDate;

            if (DateTime.TryParse(value.ToString(), out transactionDate))
            {
                if (transactionDate < DateTime.Today)
                {
                    return new ValidationResult($"La fecha no puede ser menor al dia actual",
                        new[] { validationContext.MemberName });
                }
                return null;
            }

            return new ValidationResult("Fecha invalida",
                new[] { validationContext.MemberName });
        }
    }
}
