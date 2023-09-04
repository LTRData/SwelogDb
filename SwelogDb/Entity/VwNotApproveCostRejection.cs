using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwNotApproveCostRejection
{
    public short? Year { get; set; }

    public short? MonthNo { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }

    public decimal? Cost { get; set; }
}
