using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AbsentCode
{
    public string CatPer { get; set; } = null!;

    public string AbsentCode1 { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidUntil { get; set; }

    public string? Description { get; set; }

    public decimal? WageType { get; set; }

    public decimal? RoundValue { get; set; }

    public string? TimeOfAttendence { get; set; }

    public string? ReportingUnit { get; set; }

    public string? SignalList { get; set; }

    public string? SumOfTransaction { get; set; }

    public string? AuditStamp { get; set; }
}
