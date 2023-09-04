using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductionForecast
{
    public string ForecastId { get; set; } = null!;

    public string ProductFamilyCode { get; set; } = null!;

    public DateTime ForecastPeriodDate { get; set; }

    public string ItemNumber { get; set; } = null!;

    public decimal? ProdForecastQty { get; set; }

    public decimal? ProdForecastValue { get; set; }

    public decimal? ActualProdQty { get; set; }

    public decimal? ActualProdValue { get; set; }

    public decimal? MfgProgramQuantity { get; set; }

    public decimal? MfgProgramValue { get; set; }

    public string? AuditStamp { get; set; }
}
