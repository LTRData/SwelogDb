using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SchedulableProcess
{
    public int ScheduleSerialNumber { get; set; }

    public string? ProcessId { get; set; }

    public string? LanguageCode { get; set; }

    public string? ProcessDescription { get; set; }

    public string? ProcessLongDescription { get; set; }

    public string? CommandParmText { get; set; }
}
