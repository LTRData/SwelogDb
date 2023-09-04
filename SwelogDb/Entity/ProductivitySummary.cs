using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductivitySummary
{
    public short Year { get; set; }

    public short Week { get; set; }

    public short? Month { get; set; }

    public string CostCentre { get; set; } = null!;

    public decimal? Productivity { get; set; }

    public decimal? Efficiency { get; set; }

    public decimal? UsageDegree { get; set; }

    public DateTime? CreateTimestamp { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? IndirectTimeMachine { get; set; }

    public decimal? IndirectTimeTool { get; set; }

    public decimal? IndirectTimeNonProd { get; set; }

    public decimal? IndirectTimeOther { get; set; }
}
