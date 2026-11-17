using System.ComponentModel.DataAnnotations;

namespace Autoszerelo.Contracts.Enums;

public enum JobStatus
{
    [Display(Name="Felvett Munka")] Recorded = 0,
    [Display(Name="Folyamatában")] InProgress = 1,
    [Display(Name="Kész")] Completed = 2
 
}