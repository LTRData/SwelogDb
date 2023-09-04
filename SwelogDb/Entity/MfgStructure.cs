using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgStructure
{
    public string ParentPart { get; set; } = null!;

    public string? ItemDescription { get; set; }
}
