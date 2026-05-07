using System.ComponentModel.DataAnnotations;
using Day1.DTOs;
using Day1.Models;
using Day1.Repositories;
namespace Day1.Validators
{
    public class UniqueDepartmentNameAttribute : ValidationAttribute
    {
        // inject the repository to access the database
        

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
                return ValidationResult.Success;

            var department = (DepartmentDTO)validationContext.ObjectInstance;

            
            var context = (StudentContext)validationContext.GetService(typeof(StudentContext))!;
            if (department.ID == 0) // new record 
            {
                var check = context.Departments.FirstOrDefault(d => d.Name == department.Name);
                if (check != null)
                    return new ValidationResult("Department name must be unique.");
            }
            else // existing record
            {
                var check = context.Departments.FirstOrDefault(d => d.Name == department.Name && d.ID != department.ID);
                if (check != null)
                    return new ValidationResult("Department name must be unique.");
            }


            return ValidationResult.Success;

        }
    }
}
