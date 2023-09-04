using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwFactResourceTimePerDay
{
    public string ResourceNumber { get; set; } = null!;

    public short? NumberOfResourceUnits { get; set; }

    public short? NumberOfShifts { get; set; }

    public int? YearNo { get; set; }

    public int? MonthNo { get; set; }

    public DateTime? ReportDate { get; set; }

    public decimal? ResourceTime { get; set; }

    public decimal? InterruptTime { get; set; }
}
