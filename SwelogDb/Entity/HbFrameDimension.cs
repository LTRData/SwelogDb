using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class HbFrameDimension
{
    public int DimensionId { get; set; }

    public int Breadth { get; set; }

    public int Height { get; set; }

    public bool StandardDimension { get; set; }

    public string? AuditStamp { get; set; }
}
