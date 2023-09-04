using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwNotApproveCostExtraOperation
{
    public short? Year { get; set; }

    public short? MonthNo { get; set; }

    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public short OperationNumber { get; set; }

    public decimal? Cost { get; set; }
}
