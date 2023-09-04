using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OfferLog
{
    public int IdOfferLog { get; set; }

    public string? OfferNumber { get; set; }

    public int? SimulationLotNumber { get; set; }

    public string? ChangeArea { get; set; }

    public string? ChangeBy { get; set; }

    public DateTime? ChangeDate { get; set; }

    public virtual OfferHeader? OfferNumberNavigation { get; set; }
}
