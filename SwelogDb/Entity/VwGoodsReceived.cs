using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwGoodsReceived
{
    public string SupplierId { get; set; } = null!;

    public string? SupplierName { get; set; }

    public string ProductGroup { get; set; } = null!;

    public string? ItemNumber { get; set; }

    public string? ItemDescription { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public string? CurrencyCode { get; set; }

    public string? CurrFormat { get; set; }

    public decimal PurchasedQty { get; set; }

    public decimal? LineAmtFc { get; set; }
}
