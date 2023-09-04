using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProdForecastFamily
{
    public string ProdForecastId { get; set; } = null!;

    public string SalesForecastId { get; set; } = null!;

    public string ProductFamilyCode { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public DateTime ForecastPeriodDate { get; set; }

    public decimal? ProdForecastQty { get; set; }

    public virtual ProdForecastHdr ProdForecast { get; set; } = null!;
}
