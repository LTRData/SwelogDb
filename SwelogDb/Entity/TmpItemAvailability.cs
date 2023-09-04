using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpItemAvailability
{
    public int? ProcessId { get; set; }

    public decimal? Quantity { get; set; }

    public DateTime? AvailableDate { get; set; }

    public string? Source { get; set; }

    public string? Simulate { get; set; }

    public string? Reference { get; set; }
}
