using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DeliveryPlanTextId
{
    public string CustomerId { get; set; } = null!;

    public string ItemNo { get; set; } = null!;

    public int? TextId { get; set; }
}
