using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ShiftBreak
{
    public string ShiftCode { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public short BreakSrl { get; set; }

    public DateTime? BreakStartTime { get; set; }

    public DateTime? BreakFlexiFrom { get; set; }

    public DateTime? BreakFlexiUpto { get; set; }

    public DateTime? BreakEndTime { get; set; }

    public short? BreakMinimum { get; set; }

    public string? ReportOption { get; set; }

    public string? BreakNormalFlag { get; set; }

    public string? AuditStamp { get; set; }
}
