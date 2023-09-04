using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CollectiveDeviationDtl
{
    public DateTime DivergentDate { get; set; }

    public string TimeCatg { get; set; } = null!;

    public string? ShiftCode { get; set; }

    public string? CompScheduleId { get; set; }

    public string? ExtraCompScheduleId { get; set; }

    public string? HolidayWageInd { get; set; }

    public string? StartPrevDayInd { get; set; }

    public string? AuditStamp { get; set; }

    public short? RowId { get; set; }
}
