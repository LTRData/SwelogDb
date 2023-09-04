using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SharkOutInventory
{
    public int RecNo { get; set; }

    public string? Itemnumber { get; set; }

    public decimal? Quantity { get; set; }
}
