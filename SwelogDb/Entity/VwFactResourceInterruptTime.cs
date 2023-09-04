using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwFactResourceInterruptTime
{
    public int? MfgOrderSerialKey { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public short? OperationNumber { get; set; }

    public int? InterruptMinutes { get; set; }

    public int? ReportedBy { get; set; }

    public DateTime ReportDateTime { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public string? InterruptCode { get; set; }

    public string? ToolNumber { get; set; }
}
