using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NextYearRawMaterial
{
    public int SerialNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? SupplierId { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? CalculatedPrice { get; set; }

    public decimal? SetupCost { get; set; }
}
