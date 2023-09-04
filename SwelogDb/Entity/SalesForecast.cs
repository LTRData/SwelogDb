using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SalesForecast
{
    public string ForecastId { get; set; } = null!;

    public string ProductFamilyCode { get; set; } = null!;

    public DateTime ForecastPeriodDate { get; set; }

    public decimal? ForecastQuantity { get; set; }

    public decimal? ForecastValue { get; set; }

    public decimal? ActualQuantity { get; set; }

    public decimal? ActualValue { get; set; }

    public decimal? ProdBudgetQty { get; set; }

    public decimal? ProdBudgetValue { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ForecastFamily ForecastFamily { get; set; } = null!;
}
