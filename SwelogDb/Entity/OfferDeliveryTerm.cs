using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OfferDeliveryTerm
{
    public string DeliveryTermId { get; set; } = null!;

    public string? DeliveryTermDescription { get; set; }

    public string? AuditStamp { get; set; }
}
