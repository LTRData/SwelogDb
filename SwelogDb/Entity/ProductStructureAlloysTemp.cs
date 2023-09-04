using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductStructureAlloysTemp
{
    public int SerialNumber { get; set; }

    public int? ProcessId { get; set; }

    public string? ComponentPart { get; set; }

    public decimal? CostPerParentUnit { get; set; }
}
