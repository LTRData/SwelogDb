using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ScheduleMonth
{
    public int ScheduleSerialNumber { get; set; }

    public byte? ScheduleIndicator { get; set; }

    public byte? SpecificDayNumber { get; set; }

    public byte? AlternateDayIndicator { get; set; }

    public byte? AlternateDayDow { get; set; }

    public string? MonthsList { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}
