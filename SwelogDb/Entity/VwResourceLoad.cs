using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwResourceLoad
{
    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public int LotNo { get; set; }

    public short OperationNo { get; set; }

    public string ResourceNo { get; set; } = null!;

    public short Year { get; set; }

    public short Week { get; set; }

    public short Day { get; set; }

    public decimal? ResourceLoadInHours { get; set; }

    public decimal? Capacity { get; set; }
}
