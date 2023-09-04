using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ViaForwardReservation
{
    public int IdViaForwardReservation { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public int? IdReservation { get; set; }

    public string? DeliveredYn { get; set; }
}
