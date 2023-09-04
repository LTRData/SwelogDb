using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemCostTableStructure
{
    public int ProcessId { get; set; }

    public string ItemNumber { get; set; } = null!;

    public string? LotCode { get; set; }

    public decimal? LotSize { get; set; }
}
