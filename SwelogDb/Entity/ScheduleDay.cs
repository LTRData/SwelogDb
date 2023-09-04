using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ScheduleDay
{
    public int ScheduleSerialNumber { get; set; }

    public byte? ScheduleIndicator { get; set; }

    public byte? EveryNDays { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}
