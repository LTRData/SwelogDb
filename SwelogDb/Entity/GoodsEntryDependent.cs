using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class GoodsEntryDependent
{
    public string? CustomerId { get; set; }

    public string OrderNumber { get; set; } = null!;

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public string? OrderLineType { get; set; }

    public string GoodsentryNo { get; set; } = null!;

    public DateTime ArrivalDate { get; set; }

    public decimal? DeliveryQty { get; set; }

    public string? DeliveryNoteNo { get; set; }
}
