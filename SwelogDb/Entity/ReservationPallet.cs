using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReservationPallet
{
    public int IdReservation { get; set; }

    public string PalletNo { get; set; } = null!;

    public decimal? ReservedQty { get; set; }

    public decimal? IssuedQty { get; set; }

    public decimal? RejectionQty { get; set; }

    public decimal? ReservedBreadth { get; set; }

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public DateTime? PeggingDatetime { get; set; }

    public string? OurConsignationStoreAtSupp { get; set; }
}
