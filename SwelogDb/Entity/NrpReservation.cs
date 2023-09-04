using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NrpReservation
{
    public string ItemNumber { get; set; } = null!;

    public string OrderNo { get; set; } = null!;

    public string OrderLine { get; set; } = null!;

    public decimal? ReservedQty { get; set; }

    public decimal? DeliveredQuantity { get; set; }

    public DateTime? RequiredDate { get; set; }

    public string? ReservationCode { get; set; }

    public string? ParentItem { get; set; }

    public int? LotNumber { get; set; }

    public DateTime? ParentReqdDate { get; set; }

    public string? Owner { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? AuditStamp { get; set; }

    public string? Status { get; set; }
}
