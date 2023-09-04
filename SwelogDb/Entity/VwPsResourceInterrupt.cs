using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwPsResourceInterrupt
{
    public int? YearNo { get; set; }

    public int? MonthNo { get; set; }

    public string? DepartmentNo { get; set; }

    public string ResourceNo { get; set; } = null!;

    public string InterruptCode { get; set; } = null!;

    public decimal ResourceTime { get; set; }
}
