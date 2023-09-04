using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ScheduleAdmin
{
    public int ScheduleSerialNumber { get; set; }

    public string UserId { get; set; } = null!;

    public byte? IsAdmin { get; set; }

    public byte? IsMonitor { get; set; }
}
