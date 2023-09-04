using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReservationLog
{
    public int IdReservationLog { get; set; }

    public int? IdReservation { get; set; }

    public DateTime? ChangeDate { get; set; }

    public string? UserId { get; set; }

    public decimal? ReservedQty { get; set; }
}
