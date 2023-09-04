using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwResourceLoadWithCalendar
{
    public DateTime CalendarDate { get; set; }

    public short? Year { get; set; }

    public short? MonthNo { get; set; }

    public short? WeekNo { get; set; }

    public short? DayOfWeek { get; set; }

    public string? WorkingDay { get; set; }

    public string? HolidayType { get; set; }

    public string? FiscalMonthStart { get; set; }

    public short? FiscalMonthNo { get; set; }

    public string? ExtraShiftIndicator { get; set; }

    public int? FiscalYearNo { get; set; }

    public string? HolidayRule { get; set; }

    public string? ItemNumber { get; set; }

    public string? ItemDescription { get; set; }

    public int? LotNo { get; set; }

    public short? OperationNo { get; set; }

    public string? ResourceNo { get; set; }

    public decimal? ResourceLoadInHours { get; set; }

    public decimal? Capacity { get; set; }
}
