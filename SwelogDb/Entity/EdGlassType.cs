using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EdGlassType
{
    public string GlassType { get; set; } = null!;

    public string? GlassDescription { get; set; }

    public string MainSupplier { get; set; } = null!;

    public int? InternalLeadTime { get; set; }

    public string? AuditStamp { get; set; }

    public string? AllowedItemTypes { get; set; }

    public short? Thickness { get; set; }

    public short? GlassCount32 { get; set; }

    public short? GlassCount52 { get; set; }
}
