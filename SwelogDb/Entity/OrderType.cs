using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderType
{
    public string OrderType1 { get; set; } = null!;

    public string? OrderTypeDesc { get; set; }

    public string? OrderTypeForCode { get; set; }

    public string? AuditStamp { get; set; }

    public string LanguageCode { get; set; } = null!;
}
