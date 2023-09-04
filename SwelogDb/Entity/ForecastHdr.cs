using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ForecastHdr
{
    public string ForecastId { get; set; } = null!;

    public DateTime? PeriodStartDate { get; set; }

    public DateTime? PeriodEndDate { get; set; }

    public string? MonthWeekInd { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ForecastFamily> ForecastFamilies { get; } = new List<ForecastFamily>();
}
