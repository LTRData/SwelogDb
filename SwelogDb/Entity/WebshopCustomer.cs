using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class WebshopCustomer
{
    public string CustomerId { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string? CustomerPassword { get; set; }

    public int? DefaultAheadDays { get; set; }

    public string? AuditStamp { get; set; }
}
