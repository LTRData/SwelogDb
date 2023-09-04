using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PalletPurchoprDispatch
{
    public string PalletNo { get; set; } = null!;

    public int OperationNo { get; set; }

    public int? DeliveryNoteNumber { get; set; }

    public string? ReturnGoodsentry { get; set; }

    public int? IdPurchaseOrderDtl { get; set; }

    public decimal? DispatchQty { get; set; }

    public string? PalletType { get; set; }

    public DateTime? DispatchDate { get; set; }

    public int? ActivityNo { get; set; }

    public int? PrevOperation { get; set; }

    public string? OrderDeliveryStatus { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }
}
