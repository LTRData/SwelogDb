using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwIncomingOrder
{
    public string OrderNumber { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public string? PartnerId { get; set; }

    public string? CustomerName { get; set; }

    public DateTime? PlannedDeliveryDate { get; set; }

    public string? ItemNumber { get; set; }

    public string? ItemDescription { get; set; }

    public double? OrderQuantity { get; set; }

    public double ActualDeliveredQuantity { get; set; }

    public double? OrderAmtBc { get; set; }

    public double? DeliveredAmtBc { get; set; }

    public string? ProductGroup { get; set; }

    public string? ProductGroupDescription { get; set; }

    public short? WeekNo { get; set; }

    public short? YearNo { get; set; }

    public decimal? CostPrice { get; set; }

    public string? MarketDescription { get; set; }

    public string? SalesmanName { get; set; }

    public string? SalesmanCode { get; set; }

    public string? MarketCode { get; set; }

    public string? Datemask { get; set; }

    public string? SalesUomFormat { get; set; }

    public string? StockUomFormat { get; set; }

    public string? OrderCurrencyFormat { get; set; }

    public string? BaseCurrencyFormat { get; set; }
}
