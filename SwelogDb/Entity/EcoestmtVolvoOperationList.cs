using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EcoestmtVolvoOperationList
{
    public string TopItemNumber { get; set; } = null!;

    public int TopItemLot { get; set; }

    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public int OperationNumber { get; set; }

    public decimal? OperationQuantity { get; set; }

    public string? ComponentType2 { get; set; }

    public string? PieceWorkTypeCode { get; set; }

    public string? Unit { get; set; }

    public string? UnitFormat { get; set; }

    public string? AuditStamp { get; set; }

    public string Sortstring { get; set; } = null!;

    public decimal? ParentQty { get; set; }

    public decimal? OrderLotQuantity { get; set; }

    public int? TpLotNumber { get; set; }

    public string? OrderLotQuantityText { get; set; }
}
