using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MosLoadSpecification
{
    public string ItemNo { get; set; } = null!;

    public int LotNo { get; set; }

    public short OperationNo { get; set; }

    public string ResourceNo { get; set; } = null!;

    public short Year { get; set; }

    public short Week { get; set; }

    public short Day { get; set; }

    public decimal? ResourceLoadInHours { get; set; }

    public decimal? ResourceSetupTime { get; set; }

    public decimal? OperatorLoadInHours { get; set; }

    public decimal? Manning { get; set; }
}
