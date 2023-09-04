using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemFlag
{
    public string ItemNumber { get; set; } = null!;

    public string? Pdn { get; set; }

    public string? Dst { get; set; }

    public string Deladdr { get; set; } = null!;
}
