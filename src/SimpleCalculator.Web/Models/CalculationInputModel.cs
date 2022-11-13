using System.ComponentModel.DataAnnotations;
namespace SimpleCalculator.Web.Models;

public class CalculationInputModel
{
    [Required(ErrorMessage = "Please enter the first number")]
    [Display(Name = "First number")]
    public double FirstNumber { get; set; }

    [Required(ErrorMessage = "Please enter the second number")]
    [Display(Name = "Second number")]
    public double SecondNumber { get; set; }
    public double Result { get; set; }
}
