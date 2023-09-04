using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CurrencyTableRateHistory
{
    public int SerialNumber { get; set; }

    public string? CurrencyCode { get; set; }

    public DateTime? DateOfRate { get; set; }

    public decimal? ExchangeRate { get; set; }

    public decimal? BuyingRate { get; set; }

    public decimal? SellingRate { get; set; }
}
