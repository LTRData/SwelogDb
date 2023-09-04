using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SwelogVersion
{
    public string Name { get; set; } = null!;

    public int? No { get; set; }

    public string? VersionComment { get; set; }
}
