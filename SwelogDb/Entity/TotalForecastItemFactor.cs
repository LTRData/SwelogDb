using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TotalForecastItemFactor
{
    public string ForecastId { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public decimal? Month01Factor { get; set; }

    public decimal? Month02Factor { get; set; }

    public decimal? Month03Factor { get; set; }

    public decimal? Month04Factor { get; set; }

    public decimal? Month05Factor { get; set; }

    public decimal? Month06Factor { get; set; }

    public decimal? Month07Factor { get; set; }

    public decimal? Month08Factor { get; set; }

    public decimal? Month09Factor { get; set; }

    public decimal? Month10Factor { get; set; }

    public decimal? Month11Factor { get; set; }

    public decimal? Month12Factor { get; set; }
}
