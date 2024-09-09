using System.ComponentModel.DataAnnotations;

namespace ZingCRM_Demo.Models.Validation
{
    public class CustomValidation
    {
        public class NotInThePastAttribute : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                if (value is DateOnly date)
                {
                    return date >= DateOnly.FromDateTime(DateTime.Now);
                }
                return false;
            }
        }
    }
}
