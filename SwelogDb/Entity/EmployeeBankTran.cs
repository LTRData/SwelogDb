using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EmployeeBankTran
{
    public int EmploymentNo { get; set; }

    public string WageCategory { get; set; } = null!;

    public string WagePeriod { get; set; } = null!;

    public int? FlexMinutes { get; set; }

    public int? CompMinutes { get; set; }

    public int? WorkTimeReductionMinutes { get; set; }

    public decimal? FlexBalance { get; set; }

    public decimal? CompBalance { get; set; }

    public decimal? WorkTimeReductionBalance { get; set; }

    public decimal? StopTimeBank { get; set; }

    public int? StopTimeMinutes { get; set; }
}
