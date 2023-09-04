using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PriceListDetailAlloy
{
    public string PriceListId { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public DateTime PriceListStartDate { get; set; }

    public string ItemNumber { get; set; } = null!;

    public decimal PriceListQuantityLimit { get; set; }

    public string AlloyCode { get; set; } = null!;

    public decimal? Quantity { get; set; }

    public string? AuditStamp { get; set; }

    public virtual PriceListDetail PriceListDetail { get; set; } = null!;
}
