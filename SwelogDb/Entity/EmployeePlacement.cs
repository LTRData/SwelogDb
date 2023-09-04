using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EmployeePlacement
{
    public int EmploymentNo { get; set; }

    public DateTime ValidFrom { get; set; }

    public string ActivityInd { get; set; } = null!;

    public string WorkplaceId { get; set; } = null!;

    public short PercentShare { get; set; }

    public string? Comments { get; set; }

    public string? AuditStamp { get; set; }
}
