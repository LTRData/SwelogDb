using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class WageType
{
    public string WageType1 { get; set; } = null!;

    public decimal? WageTimeRate { get; set; }

    public string? WageTypeDescription { get; set; }

    public int? WageTypeDescriptionTxtid { get; set; }

    public string? WageTypeDescriptionFlag { get; set; }

    public string? AuditStamp { get; set; }

    public string? IgnoreTimeLimit { get; set; }

    public decimal? MultiFactor { get; set; }
}
