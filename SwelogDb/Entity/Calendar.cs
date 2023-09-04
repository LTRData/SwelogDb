using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Calendar
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

    public int? ShopCalendarDate { get; set; }

    public string? ExtraShiftIndicator { get; set; }

    public string? AuditStamp { get; set; }

    public int? FiscalYearNo { get; set; }

    public int? PurchaseCalendarDate { get; set; }

    public string? HolidayRule { get; set; }
}
