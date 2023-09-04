using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OfferSimulation
{
    public int SimulationLotNumber { get; set; }

    public string OfferNumber { get; set; } = null!;

    public string? ItemNumber { get; set; }

    public int SimulationNumber { get; set; }

    public int? FreightCost { get; set; }

    public int? PackagingCost { get; set; }

    public string? PackingStructureId { get; set; }

    public decimal? QuantityGenerated { get; set; }

    public decimal? SetupPrice { get; set; }

    public decimal? SellingPrice { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? AdministrationPercentage { get; set; }

    public decimal? ProfitPercentage { get; set; }

    public string? CreatedBy { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? SpeccostCustfreight { get; set; }

    public decimal? SpeccostRework { get; set; }

    public decimal? SpeccostRejection { get; set; }

    public decimal? SpeccostToolservice { get; set; }

    public int? PriceUnitNum { get; set; }

    public string? PalletName { get; set; }

    public int? NumberPerPallet { get; set; }

    public string? SmallboxName { get; set; }

    public int? NumberPerSmallbox { get; set; }

    public string? OfferStatus { get; set; }

    public string? StatusYn { get; set; }

    public string? Comment { get; set; }

    public int? AnnualRequirement { get; set; }

    public int? MinimumSubOrder { get; set; }

    public string? PackMtrlFlag { get; set; }

    public decimal? ExchangeRate { get; set; }

    public string? PriceInOfferCurrencyYn { get; set; }

    public string? DeductSetupCostFromPriceYn { get; set; }

    public decimal? SetupCost { get; set; }

    public decimal? SetupCostPerUnit { get; set; }

    public decimal? PackingCost { get; set; }

    public int? ToolCost { get; set; }

    public int? FixtureCost { get; set; }

    public int? GaugeCost { get; set; }

    public decimal? SellingPriceOrig { get; set; }

    public decimal? SetupCostOrig { get; set; }

    public decimal? SetupCostPerUnitOrig { get; set; }

    public decimal? PackingCostOrig { get; set; }

    public int? ToolCostOrig { get; set; }

    public int? FixtureCostOrig { get; set; }

    public int? GaugeCostOrig { get; set; }

    public int? PrototypePrice { get; set; }

    public int? ToolCostPrototype { get; set; }

    public decimal? InputWeight { get; set; }

    public string? MaterialQuality { get; set; }

    public decimal? MaterialBasePrice { get; set; }

    public string? OfferSentYn { get; set; }

    public DateTime? OfferSentDate { get; set; }

    public string? ValidUntil { get; set; }

    public string? PrintExchangeRateYn { get; set; }

    public string? AlloySurchargeExcludedYn { get; set; }

    public decimal? SellingPrice2 { get; set; }

    public decimal? SellingPrice2Orig { get; set; }

    public string? PriceDeliveryTerm { get; set; }

    public string? PriceDeliveryTermCity { get; set; }

    public string? PricePrintYn { get; set; }

    public string? Price2DeliveryTerm { get; set; }

    public string? Price2DeliveryTermCity { get; set; }

    public string? Price2PrintYn { get; set; }

    public string? ActiveYn { get; set; }

    public string? OfferText { get; set; }

    public byte[]? OfferTextObject { get; set; }

    public string? LifeSpanToolFixGauge { get; set; }

    public decimal? MaterialCostBc { get; set; }

    public DateTime? DesiredOfferDate { get; set; }

    public DateTime? PrepStatusDate { get; set; }

    public string? PurchaseStatusYn { get; set; }

    public DateTime? PurchaseStatusDate { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal? SellingPriceCalc { get; set; }

    public string? CombinedOfferYn { get; set; }

    public string? OrderNumber { get; set; }

    public DateTime? EstimationBaseChangeDate { get; set; }

    public virtual ICollection<OfferItem> OfferItems { get; } = new List<OfferItem>();

    public virtual OfferHeader OfferNumberNavigation { get; set; } = null!;

    public virtual ICollection<OfferOperationDtl> OfferOperationDtls { get; } = new List<OfferOperationDtl>();

    public virtual ICollection<OfferStructureDtl> OfferStructureDtls { get; } = new List<OfferStructureDtl>();
}
