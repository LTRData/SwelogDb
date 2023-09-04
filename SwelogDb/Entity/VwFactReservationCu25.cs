using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwFactReservationCu25
{
    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public short? Year { get; set; }

    public short? WeekNo { get; set; }

    public decimal? MinimumPurchaseQuantity { get; set; }

    public decimal? CurrentBalance { get; set; }

    public decimal? ReservedQtyWeek0 { get; set; }

    public decimal? ReservedQtyWeek1 { get; set; }

    public decimal? ReservedQtyWeek2 { get; set; }
}
