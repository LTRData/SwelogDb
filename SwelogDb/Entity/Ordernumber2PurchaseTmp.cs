using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Ordernumber2PurchaseTmp
{
    public string OrderNumber2 { get; set; } = null!;

    public string PurchaseOrderNumber { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public decimal? SellingPrice { get; set; }

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public decimal? Qty { get; set; }

    public string? StockingUnit { get; set; }

    public string UserId { get; set; } = null!;

    public decimal? SetupCost { get; set; }

    public decimal? SellingPriceAmount { get; set; }
}
