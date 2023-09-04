using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DeliveryPallet
{
    public string? DeliveryNoteNumber { get; set; }

    public string PalletNo { get; set; } = null!;

    public string? OrderNo { get; set; }

    public string? OrderType { get; set; }

    public int? OrderLineNumber { get; set; }

    public int? OrderLineNumberSub { get; set; }

    public string? AuditStamp { get; set; }

    public DateTime DeliveredDatetime { get; set; }

    public string? ParentItem { get; set; }

    public int? LotNumber { get; set; }
}
