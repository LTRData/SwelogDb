using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemLevel
{
    public int SerialNumber { get; set; }

    public string? ItemNumber { get; set; }

    public short? LevelNumber { get; set; }
}
