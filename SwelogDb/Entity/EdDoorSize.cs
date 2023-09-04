using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EdDoorSize
{
    public string SizeCode { get; set; } = null!;

    public int? Breadth { get; set; }

    public int? Height { get; set; }

    public string? SingleDouble { get; set; }

    public string? AuditStamp { get; set; }

    public short? SortOrder { get; set; }

    public string? AllowedItemTypes { get; set; }
}
