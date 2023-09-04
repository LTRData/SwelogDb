using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EcoestmtSummary170
{
    public string EcoestmtType { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string LotNumber { get; set; } = null!;

    public int RowNumber { get; set; }

    public string? Identifier { get; set; }

    public string? TextToDisplay { get; set; }

    public decimal? CostHeadPercent { get; set; }

    public decimal? CostForOne { get; set; }

    public decimal? PercentForOne { get; set; }

    public decimal? CostForQuantity { get; set; }

    public decimal? PercentForQuantity { get; set; }

    public decimal? CostForLotsize { get; set; }

    public decimal? PercentForLotsize { get; set; }

    public decimal? CostForAnnreq { get; set; }

    public decimal? LotSize { get; set; }

    public string? UomFormat { get; set; }

    public decimal? AnnualRequirement { get; set; }

    public string? StockingUnit { get; set; }

    public string? ProductGroup { get; set; }

    public string? ItemType1 { get; set; }

    public string? ItemType2 { get; set; }

    public string? ItemStatus1 { get; set; }

    public string? AdditionalText { get; set; }
}
