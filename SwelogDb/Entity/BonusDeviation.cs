using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BonusDeviation
{
    public string CostCentre { get; set; } = null!;

    public int EmploymentNo { get; set; }

    public short Year { get; set; }

    public byte Month { get; set; }

    public byte DeviationFactor { get; set; }

    public string? AuditStamp { get; set; }
}
