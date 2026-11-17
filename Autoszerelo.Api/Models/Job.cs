using Autoszerelo.Contracts.Enums;

namespace Autoszerelo.Api.Models;

public class Job
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }
    public string LicensePlate { get; set; } = string.Empty;
    public int ManufacturingYear { get; set; }
    public JobCategory Category { get; set; }
    public string Description { get; set; } = string.Empty;
    public int Severity { get; set; }
    public string? RepairLog { get; set; }
    public JobStatus Status { get; set; } = JobStatus.Recorded;
    public decimal EstimatedHours{get; set;}
} /*ezt -->NE FELEJSTDS EL<--------------------------------------------
kérdezd meg hogy jó e úgy, hogy amikor létrejön adom még az értékét,
 nem fog változni dinamikusan!!+!!!!!!+"'!*/