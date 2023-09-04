using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NextYearResourceCost
{
    public int SerialNumber { get; set; }

    public string? ResourceNumber { get; set; }

    public decimal? ResourceRate { get; set; }

    public decimal? OverheadPercentage { get; set; }

    public decimal? AverageHourlyEarning { get; set; }

    public decimal? Manning { get; set; }
}
