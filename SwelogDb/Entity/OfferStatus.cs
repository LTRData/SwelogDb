using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OfferStatus
{
    public string StatusCode { get; set; } = null!;

    public string? StatusDescription { get; set; }

    public short? SortOrder { get; set; }

    public string? AuditStamp { get; set; }
}
