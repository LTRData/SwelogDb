using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderStatisticsFromLastYear
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public string? PartnerId { get; set; }

    public DateTime? PlannedDeliveryDate { get; set; }

    public double? OrderedAmount { get; set; }

    public double? DeliveredNetAmt { get; set; }

    public decimal? UndeliveredButMarkedAmt { get; set; }
}
