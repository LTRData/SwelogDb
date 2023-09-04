using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwPurchaseOperationReceival
{
    public string GoodsentryNo { get; set; } = null!;

    public DateTime ArrivalDate { get; set; }

    public string? DeliveryNoteNo { get; set; }

    public string? PartnerId { get; set; }

    public string? ItemNumber { get; set; }

    public short? MfgLot { get; set; }

    public short? MfgOperation { get; set; }

    public string? Resource { get; set; }

    public decimal? DeliveryQty { get; set; }
}
