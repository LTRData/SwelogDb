using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ScheduleWeek
{
    public int ScheduleSerialNumber { get; set; }

    public byte? EveryNWeeks { get; set; }

    public string? DaysOfWeek { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}
