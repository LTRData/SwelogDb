using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ForecastFamily
{
    public string ForecastId { get; set; } = null!;

    public string ProductFamilyCode { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual ForecastHdr Forecast { get; set; } = null!;

    public virtual ProductFamilyHdr ProductFamilyCodeNavigation { get; set; } = null!;

    public virtual ICollection<SalesForecast> SalesForecasts { get; } = new List<SalesForecast>();
}
