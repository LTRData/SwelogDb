using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OfferParent
{
    public string OfferNumber { get; set; } = null!;

    public int? SortOrder { get; set; }

    public int? Visible { get; set; }

    public string? AuditStamp { get; set; }

    public string? OfferText { get; set; }

    public byte[]? OfferTextObject { get; set; }
}
