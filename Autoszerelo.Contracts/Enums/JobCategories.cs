using System.ComponentModel.DataAnnotations;

namespace Autoszerelo.Contracts.Enums;

public enum JobCategories
{
    [Display(Name = "Karosszéria")]Bodywork,
    [Display(Name = "Motor")]Engine,
    [Display(Name = "Futómű")]Suspension,
    [Display(Name = "Fékberendezés")]Brakes
}