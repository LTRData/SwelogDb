using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpVolvoOperationList
{
    public string? ItemNumber { get; set; }

    public string? ItemDescription { get; set; }

    public int? OperationNumber { get; set; }

    public decimal? OperationQuantity { get; set; }

    public string? ComponentType2 { get; set; }

    public string? PieceWorkTypeCode { get; set; }

    public int IdTmpVolvoOperationList { get; set; }

    public int? Spid { get; set; }

    public string? Unit { get; set; }

    public string? UnitFormat { get; set; }

    public string? AuditStamp { get; set; }

    public string? Sortstring { get; set; }

    public decimal? ParentQty { get; set; }

    public decimal? OrderLotQuantity { get; set; }

    public int? TpLotNumber { get; set; }
}
