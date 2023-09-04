using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductivityPerShift
{
    public short Year { get; set; }

    public short Week { get; set; }

    public short Month { get; set; }

    public string CostCentre { get; set; } = null!;

    public string ShiftCode { get; set; } = null!;

    public decimal? Productivity { get; set; }

    public decimal? Efficiency { get; set; }

    public decimal? UsageDegree { get; set; }

    public DateTime? CreateTimestamp { get; set; }

    public decimal? Quantity { get; set; }
}
