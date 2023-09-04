using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class HolidayType
{
    public string HolidayType1 { get; set; } = null!;

    public string? HolidayName { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<CalendarFreeDay> CalendarFreeDays { get; } = new List<CalendarFreeDay>();
}
