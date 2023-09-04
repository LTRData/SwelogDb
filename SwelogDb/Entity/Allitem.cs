using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Allitem
{
    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public int? ItemDescriptionTxtid { get; set; }

    public string? ItemType1 { get; set; }
}
