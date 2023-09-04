using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpComponentTree
{
    public int? Spid { get; set; }

    public int IdItemComponent { get; set; }

    public int? CompLevel { get; set; }

    public string? ItemNumber { get; set; }

    public string? ParentPart { get; set; }

    public int? ParentIdItemComponent { get; set; }

    public decimal? Qty { get; set; }

    public decimal? ParentQty { get; set; }

    public int? Operation { get; set; }

    public string? PositionIndicator { get; set; }

    public string? Sortorder { get; set; }

    public string? ItemPath { get; set; }

    public int? CostType { get; set; }
}
