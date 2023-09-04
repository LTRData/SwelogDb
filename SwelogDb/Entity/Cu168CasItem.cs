using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu168CasItem
{
    public string CasNumber { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public decimal? PercentComp { get; set; }

    public bool? SammansattningFlag { get; set; }

    public bool? KompletterandeFaroinformationFlag { get; set; }

    public string? AuditStamp { get; set; }
}
