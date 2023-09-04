using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class IndirectActivity
{
    public string IndirectActivityCode { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidUpto { get; set; }

    public string? IndirectActivityDesc { get; set; }

    public int? IndirectActivityDescTxtid { get; set; }

    public string? IndirectActivityDescFlag { get; set; }

    public string? WageType { get; set; }

    public string? ActivityInd { get; set; }

    public string? AuditStamp { get; set; }

    public string? CostCentre { get; set; }

    public string? DivisionFlag { get; set; }

    public string? ActivityType { get; set; }
}
