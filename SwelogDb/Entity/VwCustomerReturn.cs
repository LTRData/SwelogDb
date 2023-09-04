using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwCustomerReturn
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public DateTime? OrderDate { get; set; }

    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public decimal? OrderQuantity { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public double? DeliveryQuantity { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public decimal? ReturnedQuantity { get; set; }

    public int TranSerial { get; set; }

    public DateTime ReturnedDate { get; set; }

    public string? UomFormat { get; set; }

    public string? Datemask { get; set; }

    public decimal? TotalDeliveredQuantity { get; set; }

    public decimal? TotalReturnedQuantity { get; set; }
}
