using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class HbFilterMaterial
{
    public string MaterialId { get; set; } = null!;

    public string MaterialDescription { get; set; } = null!;

    public string Prefix { get; set; } = null!;

    public string Leading { get; set; } = null!;

    public string PrefixInDescription { get; set; } = null!;

    public int OperationNumberStitchPacket { get; set; }

    public string? AuditStamp { get; set; }

    public int? OperationNumberStitching { get; set; }

    public int? OperationNumberStitchingBig { get; set; }

    public int? OperationNumberSeam { get; set; }
}
