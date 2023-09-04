using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwContractOrderItem
{
    public string? CustomerNo { get; set; }

    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public decimal? ExchRateForSales { get; set; }

    public decimal? SellingPriceStockUnitFcGross { get; set; }

    public decimal? SellingPriceStockUnitFcNet { get; set; }

    public decimal? SellingPriceStockUnitBcGross { get; set; }

    public decimal? SellingPriceStockUnitBcNet { get; set; }

    public DateTime? NextDelivery { get; set; }

    public DateTime? LastDelivery { get; set; }

    public decimal? ConsignationQty { get; set; }

    public string OrderLineStatus { get; set; } = null!;
}
