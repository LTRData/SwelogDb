using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemSegmentParent
{
    public string SegmentParentId { get; set; } = null!;

    public string? SegmentParentDesc { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ItemSegment> ItemSegments { get; } = new List<ItemSegment>();
}
