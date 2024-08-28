using DataAnnotationsExample.Models;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationsExample.Validator;

public class InUniversityValidationAttribute : ValidationAttribute
{
                                                // Boxing / UnBoxing    
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        Student student = (Student)validationContext.ObjectInstance; // explicit cast
        if (!student.UniversityStudent)
        {
            return new ValidationResult(
                "Sorry you must be a student of the university in order to submit");
        }
        return ValidationResult.Success;
    }
}
