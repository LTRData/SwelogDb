using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EdWoodType
{
    public string WoodType { get; set; } = null!;

    public string? WoodDescription { get; set; }

    public string? FrameWoodType { get; set; }

    public string? AuditStamp { get; set; }

    public short? SortOrder { get; set; }
}
