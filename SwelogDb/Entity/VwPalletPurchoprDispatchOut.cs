using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwPalletPurchoprDispatchOut
{
    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public int OperationNo { get; set; }

    public int? IdPurchaseOrderDtl { get; set; }

    public int? DeliveryNoteNumber { get; set; }

    public DateTime? DispatchDate { get; set; }

    public string? PalletType { get; set; }

    public string PalletNo { get; set; } = null!;

    public decimal? DispatchQty { get; set; }

    public decimal? ReturnedQty { get; set; }
}
