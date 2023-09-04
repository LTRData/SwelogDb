using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ErrandReport
{
    public int IdErrand { get; set; }

    public int YearNo { get; set; }

    public int WeekNo { get; set; }

    public decimal ReportedTime { get; set; }

    public string Element { get; set; } = null!;

    public string ReportedBy { get; set; } = null!;

    public short? MonthNo { get; set; }
}
