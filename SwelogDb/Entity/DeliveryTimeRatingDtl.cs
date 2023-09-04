using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DeliveryTimeRatingDtl
{
    public string DeliveryTimeId { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public short PointScoreSerial { get; set; }

    public short? PointScore { get; set; }

    public short? LateDelivery { get; set; }

    public short? EarlyDelivery { get; set; }

    public string? AuditStamp { get; set; }
}
