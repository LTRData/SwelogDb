using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ScheduleMinute
{
    public int ScheduleSerialNumber { get; set; }

    public byte? EveryNMinutes { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}
