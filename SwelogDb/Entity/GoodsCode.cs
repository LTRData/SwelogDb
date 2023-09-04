using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class GoodsCode
{
    public string GoodsCode1 { get; set; } = null!;

    public string? GoodsDescription { get; set; }

    public short? FirstCount { get; set; }

    public short? SecondCount { get; set; }

    public short? ThirdCount { get; set; }

    public short? CornerCount { get; set; }

    public string? AuditStamp { get; set; }

    public bool? PrintFlag { get; set; }
}
