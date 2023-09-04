using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SalesForecastUserPref
{
    public string Userid { get; set; } = null!;

    public string? MarketCode { get; set; }

    public string? TerritoryCode { get; set; }

    public string? SalesmanCode { get; set; }

    public byte? SortItem { get; set; }

    public string? CategoryFrom { get; set; }

    public string? CategoryTo { get; set; }
}
