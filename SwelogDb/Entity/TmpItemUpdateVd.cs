using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpItemUpdateVd
{
    public string ItemNumber { get; set; } = null!;

    public decimal? SellingPrice { get; set; }

    public decimal? CostPrice { get; set; }
}
