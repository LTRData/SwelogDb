using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ScheduledProcess
{
    public int ScheduleSerialNumber { get; set; }

    public string? ScheduleType { get; set; }

    public DateTime? LastRunStarted { get; set; }

    public DateTime? LastRunCompleted { get; set; }

    public DateTime? NextRunDate { get; set; }

    public string? CommandParm { get; set; }

    public string? AuditStamp { get; set; }
}
