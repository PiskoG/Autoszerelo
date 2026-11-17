using System.ComponentModel.DataAnnotations;

namespace Autoszerelo.Contracts.Enums;

public enum JobCategory
{
    [Display(Name = "Karosszéria")]Bodywork,
    [Display(Name = "Motor")]Engine,
    [Display(Name = "Futómű")]Suspension,
    [Display(Name = "Fékberendezés")]Brakes
}