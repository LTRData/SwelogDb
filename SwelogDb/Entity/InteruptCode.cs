using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class InteruptCode
{
    public string InteruptCode1 { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidUpto { get; set; }

    public string? InteruptDescription { get; set; }

    public string? IndirectActivityCode { get; set; }

    public string? AuditStamp { get; set; }

    public string? ResourceNumber { get; set; }
}
