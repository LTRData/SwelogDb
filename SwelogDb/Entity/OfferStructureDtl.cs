using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OfferStructureDtl
{
    public string ParentPart { get; set; } = null!;

    public int SimulationLotNumber { get; set; }

    public string ComponentPart { get; set; } = null!;

    public decimal? QuantityOfComponent { get; set; }

    public decimal? CostPrice { get; set; }

    public int? ComponentPartTxtid { get; set; }

    public string? PositionIndicator { get; set; }

    public int? OperationNumber { get; set; }

    public string? DoNotCalculateYn { get; set; }

    public string? AuditStamp { get; set; }

    public string? ComponentUnitMeasure { get; set; }

    public decimal? SpeccostMatfreight { get; set; }

    public int? PriceUnitNum { get; set; }

    public string? CostPriceExchangeCurrency { get; set; }

    public decimal? CostPriceExchangeRate { get; set; }

    public DateTime? LastCostPriceChangeDate { get; set; }

    public string? DoNotCalculateOverheadProfitYn { get; set; }

    public decimal? OfferPrice { get; set; }

    public decimal? OverheadFactor { get; set; }

    public virtual OfferSimulation SimulationLotNumberNavigation { get; set; } = null!;
}
