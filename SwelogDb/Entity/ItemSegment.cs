using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemSegment
{
    public string SegmentId { get; set; } = null!;

    public string? SegmentDescription { get; set; }

    public string? AuditStamp { get; set; }

    public string? SegmentParentId { get; set; }

    public virtual ItemSegmentParent? SegmentParent { get; set; }
}
