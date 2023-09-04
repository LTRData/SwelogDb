using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwDimItem
{
    public string? ItemNumber { get; set; }

    public string? ProductGroup { get; set; }

    public string? ItemDescription { get; set; }

    public string? ProductGroupDescription { get; set; }
}
