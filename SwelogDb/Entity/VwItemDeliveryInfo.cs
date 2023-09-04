using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwItemDeliveryInfo
{
    public string ItemNumber { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public string DeliveryAddressId { get; set; } = null!;

    public string? PackingStructureId { get; set; }

    public string? ConsigneeName { get; set; }

    public string? Route { get; set; }

    public string? StorageName { get; set; }

    public string? UnloadingDescription { get; set; }
}
