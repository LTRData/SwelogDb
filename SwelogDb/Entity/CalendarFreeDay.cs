using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CalendarFreeDay
{
    public DateTime CalendarDate { get; set; }

    public string? HolidayType { get; set; }

    public string? AuditStamp { get; set; }

    public virtual HolidayType? HolidayTypeNavigation { get; set; }
}
