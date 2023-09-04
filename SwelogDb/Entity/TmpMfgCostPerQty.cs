using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpMfgCostPerQty
{
    public int RecId { get; set; }

    public string? MfgOrderType { get; set; }

    public int? YearNo { get; set; }

    public string? ProductGroup { get; set; }

    public string? ToolNumber { get; set; }

    public string? ToolDescription { get; set; }

    public decimal? CostPerQty1 { get; set; }

    public decimal? CostPerQty2 { get; set; }

    public decimal? CostPerQty3 { get; set; }

    public decimal? CostPerQty4 { get; set; }

    public decimal? CostPerQty5 { get; set; }

    public decimal? CostPerQty6 { get; set; }

    public decimal? CostPerQty7 { get; set; }

    public decimal? CostPerQty8 { get; set; }

    public decimal? CostPerQty9 { get; set; }

    public decimal? CostPerQty10 { get; set; }

    public decimal? CostPerQty11 { get; set; }

    public decimal? CostPerQty12 { get; set; }

    public decimal? CostPerQtyAccu { get; set; }

    public string? AuditStamp { get; set; }
}
