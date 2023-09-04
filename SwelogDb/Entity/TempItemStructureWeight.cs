using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TempItemStructureWeight
{
    public string? ItemNumber { get; set; }

    public string? Identification { get; set; }

    public decimal? ParentQty { get; set; }

    public string? ComponentPart { get; set; }

    public decimal? ComponentQty { get; set; }

    public decimal? Weight { get; set; }

    public decimal? ItemWeight { get; set; }

    public decimal? StructureWeight { get; set; }
}
