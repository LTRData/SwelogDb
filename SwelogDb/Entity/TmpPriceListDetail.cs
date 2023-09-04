using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpPriceListDetail
{
    public int ProcessId { get; set; }

    public int RecNo { get; set; }

    public string? PriceListId { get; set; }

    public string? CurrencyCode { get; set; }

    public DateTime? PriceListStartDate { get; set; }

    public string? ItemNumber { get; set; }

    public decimal? PriceListQuantityLimit { get; set; }

    public decimal? SellingPrice { get; set; }

    public decimal? PriceUnit { get; set; }
}
