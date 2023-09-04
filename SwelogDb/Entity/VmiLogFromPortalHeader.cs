using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VmiLogFromPortalHeader
{
    public int SerialNumber { get; set; }

    public DateTime? ExecutionTimestamp { get; set; }

    public string? LogMessage { get; set; }

    public string? Status { get; set; }

    public byte? CriticalityLevel { get; set; }
}
