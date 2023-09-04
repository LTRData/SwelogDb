using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OfferOperationDtl
{
    public string OperationList { get; set; } = null!;

    public int SimulationLotNumber { get; set; }

    public int OperationNumber { get; set; }

    public string? OperationDesc { get; set; }

    public string? ResourceNumber { get; set; }

    public decimal? OperationSetUpTime { get; set; }

    public decimal? ResourceSetUpTime { get; set; }

    public decimal? OperationTime { get; set; }

    public decimal? ResourceTime { get; set; }

    public int? UnitConversionFactor { get; set; }

    public string? PieceWorkTypeCode { get; set; }

    public decimal? AverageHourlyEarning { get; set; }

    public decimal? ResourceRate { get; set; }

    public decimal? CapitalCost { get; set; }

    public int? OperationDescTxtid { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? PieceWorkRate { get; set; }

    public decimal? TimeWorkRate { get; set; }

    public decimal? TimeRateFixedPart { get; set; }

    public decimal? OperationCostingPrice { get; set; }

    public decimal? OperationSetupCost { get; set; }

    public decimal? SpeccostPurchoprfreightSv { get; set; }

    public decimal? SpeccostPurchoprfreightEu { get; set; }

    public decimal? FinancialCost { get; set; }

    public decimal? DepresCost { get; set; }

    public string? ResourceDocument { get; set; }

    public decimal? SpeccostRework { get; set; }

    public decimal? SpeccostRejection { get; set; }

    public decimal? SpeccostToolservice { get; set; }

    public decimal? SpeccostTool { get; set; }

    public decimal? SpeccostFixture { get; set; }

    public decimal? SpeccostGauge { get; set; }

    public DateTime? OperationLastChangeDate { get; set; }

    public decimal? CostPriceExchangeRate { get; set; }

    public string? CostPriceExchangeCurrency { get; set; }

    public decimal? ItemWeight { get; set; }

    public decimal? HourlyDebitPriceOut { get; set; }

    public decimal? OfferOperationCostingPrice { get; set; }

    public decimal? OfferOperationSetupCost { get; set; }

    public virtual ICollection<OfferToolFixtureGauge> OfferToolFixtureGauges { get; } = new List<OfferToolFixtureGauge>();

    public virtual OfferSimulation SimulationLotNumberNavigation { get; set; } = null!;
}
