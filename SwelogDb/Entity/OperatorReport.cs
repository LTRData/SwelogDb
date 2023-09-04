using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OperatorReport
{
    public int EmployeeNumber { get; set; }

    public DateTime StartDateTime { get; set; }

    public string WorkPlaceId { get; set; } = null!;

    public string? ActivityInd { get; set; }

    public string? AuditStamp { get; set; }

    public int? AttestedBy { get; set; }

    public DateTime? AttestedDateTime { get; set; }

    public string? BonusFlag { get; set; }
}
