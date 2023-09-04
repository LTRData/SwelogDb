using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemVariantFree
{
    public string ItemNumber { get; set; } = null!;

    public int? VariantFree { get; set; }
}
