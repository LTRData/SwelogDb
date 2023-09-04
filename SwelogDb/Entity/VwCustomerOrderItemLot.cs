using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwCustomerOrderItemLot
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public string? ItemNumber { get; set; }

    public string? MfgOrderNumber { get; set; }

    public int? MfgLotNumber { get; set; }
}
