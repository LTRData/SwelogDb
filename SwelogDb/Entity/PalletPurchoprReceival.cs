using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PalletPurchoprReceival
{
    public DateTime ReceivalDatetime { get; set; }

    public string Item { get; set; } = null!;

    public string Goodsentry { get; set; } = null!;

    public string PalletNo { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public string? ReceiveYn { get; set; }

    public decimal? Qty { get; set; }

    public string? Location { get; set; }

    public string? Position { get; set; }

    public string? PalletType { get; set; }

    public decimal? ApprovedQty { get; set; }

    public decimal? InspectedQty { get; set; }

    public int? IdPurchaseOrderDtl { get; set; }

    public string? SourcePalletNo { get; set; }
}
