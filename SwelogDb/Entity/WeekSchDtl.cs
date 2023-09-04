using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class WeekSchDtl
{
    public string WkSchedule { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public short DaySrl { get; set; }

    public string? ShiftCode { get; set; }

    public string? CompSch { get; set; }

    public string? ExtraCompSch { get; set; }

    public string? AuditStamp { get; set; }

    public string? StartPrevDayInd { get; set; }
}
