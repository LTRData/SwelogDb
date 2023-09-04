using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProdForecastSale
{
    public string ProdForecastId { get; set; } = null!;

    public string SalesForecastId { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual ProdForecastHdr ProdForecast { get; set; } = null!;
}
