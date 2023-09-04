using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProdForecastHdr
{
    public string ProdForecastId { get; set; } = null!;

    public DateTime? PeriodStartDate { get; set; }

    public DateTime? PeriodEndDate { get; set; }

    public string? MonthWeekInd { get; set; }

    public string? AuditStamp { get; set; }

    public int? PeriodStartYear { get; set; }

    public int? PeriodEndYear { get; set; }

    public int? PeriodStartWeek { get; set; }

    public int? PeriodEndWeek { get; set; }

    public virtual ICollection<ProdForecastDtl> ProdForecastDtls { get; } = new List<ProdForecastDtl>();

    public virtual ICollection<ProdForecastFamily> ProdForecastFamilies { get; } = new List<ProdForecastFamily>();

    public virtual ICollection<ProdForecastSale> ProdForecastSales { get; } = new List<ProdForecastSale>();
}
