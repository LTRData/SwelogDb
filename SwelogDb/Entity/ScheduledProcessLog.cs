using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ScheduledProcessLog
{
    public string ProcessId { get; set; } = null!;

    public DateTime LogDateTime { get; set; }

    public string? WorkStation { get; set; }

    public string? SwelogUser { get; set; }

    public string? LogText { get; set; }

    public DateTime? StartDateTime { get; set; }

    public DateTime? FinishDateTime { get; set; }
}
