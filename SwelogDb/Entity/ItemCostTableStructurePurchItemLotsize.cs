using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemCostTableStructurePurchItemLotsize
{
    public int IdItemCostTableStructurePurchItemLotsize { get; set; }

    public int ProcessId { get; set; }

    public string PurcCompItemNumber { get; set; } = null!;

    public string? LotCode { get; set; }

    public decimal? QuantityOfComponent { get; set; }

    public decimal? ItemLotSize { get; set; }

    public decimal? CalcDemand { get; set; }

    public decimal? LotSize { get; set; }
}
