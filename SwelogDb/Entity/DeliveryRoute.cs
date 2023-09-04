using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DeliveryRoute
{
    public string DeliveryRouteCode { get; set; } = null!;

    public string? DeliveryRouteDesc { get; set; }

    public int? DeliveryRouteDescTxtid { get; set; }

    public string? DeliveryRouteDescFlag { get; set; }

    public string? AuditStamp { get; set; }
}
