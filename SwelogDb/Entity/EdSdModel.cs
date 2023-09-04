using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EdSdModel
{
    public string ModelNumber { get; set; } = null!;

    public string? ModelDescription { get; set; }

    public string? ItemType { get; set; }

    public int? MinBreadth { get; set; }

    public bool? FrameOnly { get; set; }

    public string? AuditStamp { get; set; }
}
