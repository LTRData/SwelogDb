using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwErrandReportLast
{
    public int IdErrand { get; set; }

    public int YearNo { get; set; }

    public int WeekNo { get; set; }

    public decimal ReportedTime { get; set; }
}
