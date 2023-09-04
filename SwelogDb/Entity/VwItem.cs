using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwItem
{
    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public string? ItemType1 { get; set; }

    public string? ItemType2 { get; set; }

    public string? StockingUnit { get; set; }

    public decimal? CostPrice { get; set; }

    public string? ArrivalInspectionIndicator { get; set; }

    public decimal? ItemCurrentBalance { get; set; }

    public decimal? ItemReservedQty { get; set; }

    public decimal? ItemMfgOrderQty { get; set; }

    public decimal? ItemPurchOrderQty { get; set; }

    public decimal? OrderLotQuantity { get; set; }

    public decimal? CurrentAtpQty { get; set; }

    public decimal? FinalAtpQty { get; set; }

    public decimal? FinalReorderNetQty { get; set; }

    public string? MainSupplier { get; set; }

    public string? PlannerId { get; set; }

    public string? StockLocation { get; set; }

    public string ReorderPointYn { get; set; } = null!;

    public short? PriceUnitNum { get; set; }

    public string? FormatString { get; set; }

    public string? ProductGroup { get; set; }
}
