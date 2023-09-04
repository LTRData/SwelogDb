using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwDimCalendar
{
    public DateTime CalendarDate { get; set; }

    public short? Year { get; set; }

    public short? MonthNo { get; set; }

    public short? WeekNo { get; set; }

    public int? FiscalYearNo { get; set; }

    public string? MonthName { get; set; }

    public decimal? QuarterNo { get; set; }
}
