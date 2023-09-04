using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PoSuggestNew
{
    public int SerialNo { get; set; }

    public DateTime? SuggestDate { get; set; }

    public string? PlannerId { get; set; }

    public string? SupplierId { get; set; }

    public string? ItemNumber { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Dispqty { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? RaiseDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public short? InternalLeadTime { get; set; }

    public short? DeliveryTimeInDays { get; set; }

    public short? TransportTimeInDays { get; set; }

    public short? TurnAroundTime { get; set; }

    public short? MarginTime { get; set; }

    public string? PoCode { get; set; }

    public string? OrderLine { get; set; }

    public string? OrderNumber { get; set; }

    public string? DemandIds { get; set; }
}
