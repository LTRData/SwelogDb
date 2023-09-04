using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwFactResourceInterruptTimePerMonth
{
    public string ResourceNumber { get; set; } = null!;

    public string? ItemNumber { get; set; }

    public string? InterruptCode { get; set; }

    public string? ToolNumber { get; set; }

    public int? YearNo { get; set; }

    public int? MonthNo { get; set; }

    public decimal? InterruptTime { get; set; }

    public decimal? ResourceTime { get; set; }

    public int? NoOfWorkingDays { get; set; }

    public short? NumberOfResourceUnits { get; set; }

    public short? NumberOfShifts { get; set; }
}
