using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class HbPocketDepth
{
    public int PocketDepth { get; set; }

    public int Prefix { get; set; }

    public string? AuditStamp { get; set; }
}
