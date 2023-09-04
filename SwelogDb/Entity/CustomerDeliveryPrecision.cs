using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerDeliveryPrecision
{
    public int RecNo { get; set; }

    public string? CustomerId { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public short? OrderLineNumberSub { get; set; }

    public string? ItemNumber { get; set; }

    public decimal? OrderQuantity { get; set; }

    public decimal? DeliveredQuantity { get; set; }

    public DateTime? PlannedDeliveryDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? ReservationCode { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public string? Status { get; set; }

    public DateTime? PromisedDeliveryDate { get; set; }

    public string? OrderLineType { get; set; }

    public DateTime? TimeStamp { get; set; }

    public int? IdReservation { get; set; }

    public virtual CustomerDeliveryHeader? DeliveryNoteNumberNavigation { get; set; }
}
