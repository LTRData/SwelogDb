using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PoSuggestShift
{
    public int SerialNo { get; set; }

    public DateTime? SuggestDate { get; set; }

    public string? PlannerId { get; set; }

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public short? OrderLineNumberSub { get; set; }

    public DateTime? PlannedDeliveryDate { get; set; }

    public string? DeliveryAddressId { get; set; }

    public string? ItemNumber { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Dispqty { get; set; }

    public DateTime? ShiftDate { get; set; }

    public string? ShiftFlag { get; set; }

    public DateTime? RaiseDate { get; set; }

    public string? SupplierId { get; set; }
}
