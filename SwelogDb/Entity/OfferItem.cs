using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OfferItem
{
    public string ItemNumber { get; set; } = null!;

    public int SimulationLotNumber { get; set; }

    public int? OrderLotQuantity { get; set; }

    public string? AuditStamp { get; set; }

    public string? LotCode { get; set; }

    public virtual OfferSimulation SimulationLotNumberNavigation { get; set; } = null!;
}
