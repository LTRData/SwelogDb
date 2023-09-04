using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class HbPocketSlant
{
    public int PocketId { get; set; }

    public int PocketDepthLong { get; set; }

    public int PocketDepthShort { get; set; }

    public string? AuditStamp { get; set; }
}
