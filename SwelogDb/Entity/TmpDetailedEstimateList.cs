using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpDetailedEstimateList
{
    public int Spid { get; set; }

    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public string? ItemDescr { get; set; }

    public decimal? RawMatrl { get; set; }

    public decimal? PurchItem { get; set; }

    public decimal? MatrlOh { get; set; }

    public decimal? DirectWage { get; set; }

    public decimal? MfgOh { get; set; }

    public decimal? MfgSumExclSetup { get; set; }

    public decimal? AdmOh { get; set; }

    public decimal? SelfCostExclSetup { get; set; }

    public decimal? Profit { get; set; }

    public decimal? CalcSellingPrice { get; set; }

    public decimal? Tb1 { get; set; }

    public decimal? Tb2 { get; set; }

    public decimal? SetupCost { get; set; }

    public decimal? CurrentCostprice { get; set; }

    public decimal? CurrentSellingprice { get; set; }

    public decimal? ItemAnnualRequirement { get; set; }

    public decimal? CurrentYearIssue { get; set; }

    public string? StockingUnit { get; set; }
}
