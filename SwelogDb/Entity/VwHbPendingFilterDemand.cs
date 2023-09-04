using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwHbPendingFilterDemand
{
    public short? Year { get; set; }

    public short? WeekNo { get; set; }

    public string? MaterialDescription { get; set; }

    public decimal? PendingQty { get; set; }

    public string OrderNo { get; set; } = null!;

    public string? OrderLine { get; set; }

    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public decimal? ReservedQty { get; set; }

    public decimal? DeliveredQuantity { get; set; }

    public string? Owner { get; set; }

    public string? CustomerName { get; set; }
}
