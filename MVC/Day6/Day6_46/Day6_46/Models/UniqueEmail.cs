using System.ComponentModel.DataAnnotations;

namespace Day6_46.Models
{
    public class UniqueEmail: ValidationAttribute
    {
        public UniqueEmail()
        {
                
        }

        protected override ValidationResult? IsValid(object obj, ValidationContext validationContext)
        {
            if (obj == null)
            {
                return new ValidationResult("Email Coundn't be NULL!!!!");
            }
            else
            {
                if (obj is string)
                {
                    string suppliedValue = (string)obj;

                    StdDbContext context = new StdDbContext();
                    var EmailExist = context.Students.Any(std => std.Email == suppliedValue);

                    //var EmailExist = context.Students.Any(std => std.Email == suppliedValue)
                    //    && ((Student)validationContext.ObjectInstance).DeptID == 1;


                    if (EmailExist == false)
                    {
                        return ValidationResult.Success;
                    }
                    else
                    {
                        ErrorMessage = "The Email " + suppliedValue + " already taken!!!!";
                        return new ValidationResult(ErrorMessage);
                    }
                }
                    
                    else
                    {
                return new ValidationResult("Email have to be string");

                }
            }

        }
    }
}
