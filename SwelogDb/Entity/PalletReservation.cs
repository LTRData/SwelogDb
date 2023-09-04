using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PalletReservation
{
    public int PalletNo { get; set; }

    public string ReservationId { get; set; } = null!;

    public decimal? ReserveQty { get; set; }

    public DateTime? RequiredDate { get; set; }

    public string? AuditStamp { get; set; }
}
