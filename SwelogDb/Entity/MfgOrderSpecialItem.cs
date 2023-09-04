using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgOrderSpecialItem
{
    public string MfgOrderNumber { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public short OperationNumber { get; set; }

    public short SequenceNumber { get; set; }

    public string? NonStockItemNumber { get; set; }

    public string? NonStockItemDesc { get; set; }

    public int? NonStockItemDescTxtid { get; set; }

    public decimal? ItemRequiredQuantity { get; set; }

    public string? Uom { get; set; }

    public decimal? Price { get; set; }

    public string? UnitOfPrice { get; set; }

    public string? SupplierId { get; set; }

    public string? AuditStamp { get; set; }

    public string? PurchaseOrder { get; set; }

    public virtual MfgOrderDtl MfgOrderDtl { get; set; } = null!;
}
