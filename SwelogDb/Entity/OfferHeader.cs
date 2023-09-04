using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OfferHeader
{
    public string OfferNumber { get; set; } = null!;

    public string? ParentOfferNumber { get; set; }

    public DateTime? OfferDate { get; set; }

    public int CrmSerialNumber { get; set; }

    public string? CrmId { get; set; }

    public string? ContactName { get; set; }

    public string? PurchaseRequestNumber { get; set; }

    public string MainResponsible { get; set; } = null!;

    public string? ItemNumber { get; set; }

    public string? BaseStatus { get; set; }

    public string? PrepStatus { get; set; }

    public string? Field1 { get; set; }

    public string? Field1Data { get; set; }

    public string? Field2 { get; set; }

    public string? Field2Data { get; set; }

    public string? Field3 { get; set; }

    public string? Field3Data { get; set; }

    public string? Field4 { get; set; }

    public string? Field4Data { get; set; }

    public string? Field5 { get; set; }

    public string? Field5Data { get; set; }

    public string? AuditStamp { get; set; }

    public int? AnnualRequirement { get; set; }

    public string? DrawingNo { get; set; }

    public string? RevisionNo { get; set; }

    public string? CreatedBy { get; set; }

    public string? PackMtrlFlag { get; set; }

    public string? OurReference { get; set; }

    public string? CustomerItemNumber { get; set; }

    public int? MinimumSubOrder { get; set; }

    public string? CurrencyCode { get; set; }

    public string? LanguageCode { get; set; }

    public string? PaymentTerm { get; set; }

    public string? PictureFileName { get; set; }

    public string? DeliveryTimeSample { get; set; }

    public string? DeliveryTimeAfterApprovedSample { get; set; }

    public string? MaterialQuality { get; set; }

    public string? MaterialBasePrice { get; set; }

    public string? LifeSpanToolFixGuage { get; set; }

    public string? PaymentTermToolFixGauge { get; set; }

    public string? PaymentTermToolFixGaugeExtra { get; set; }

    public DateTime? ValidUntil { get; set; }

    public string? Comments { get; set; }

    public byte[]? LongTextObject { get; set; }

    public decimal? DetailWeight { get; set; }

    public decimal? InputWeight { get; set; }

    public decimal? SellingPrice { get; set; }

    public decimal? SetupCost { get; set; }

    public decimal? PackingCost { get; set; }

    public decimal? ExchangeRate { get; set; }

    public decimal? SetupCostPerUnit { get; set; }

    public string? AddSetupCostToPriceYn { get; set; }

    public int? ContactSerialNumber { get; set; }

    public int? ToolCost { get; set; }

    public int? FixtureCost { get; set; }

    public int? GaugeCost { get; set; }

    public string? DeductSetupCostFromPriceYn { get; set; }

    public string? PriceInOfferCurrencyYn { get; set; }

    public string? CustomerItemDescription { get; set; }

    public decimal? PictureWhFactor { get; set; }

    public string? OfferType { get; set; }

    public DateTime? DesiredOfferDate { get; set; }

    public int? PrototypePrice { get; set; }

    public int? ToolCostPrototype { get; set; }

    public string? DeliveryTimePrototype { get; set; }

    public string? OfferSentYn { get; set; }

    public DateTime? OfferSentDate { get; set; }

    public decimal? SellingPriceOrig { get; set; }

    public decimal? SetupCostPerUnitOrig { get; set; }

    public decimal? SetupCostOrig { get; set; }

    public decimal? PackingCostOrig { get; set; }

    public int? ToolCostOrig { get; set; }

    public int? FixtureCostOrig { get; set; }

    public int? GaugeCostOrig { get; set; }

    public string? PaymentTermToolFixGaugeExtra2 { get; set; }

    public string? PaymentTermToolFixGaugeExtra3 { get; set; }

    public int? ValidSimulationLotNumber { get; set; }

    public string? OfferStatus { get; set; }

    public string? HotOfferYn { get; set; }

    public DateTime? PpapDate { get; set; }

    public DateTime? SopDate { get; set; }

    public DateTime? StatusChangeDate { get; set; }

    public string? TfqAttest1Yn { get; set; }

    public string? TfqAttest1By { get; set; }

    public DateTime? TfqAttest1Date { get; set; }

    public string? TfqAttest2Yn { get; set; }

    public string? TfqAttest2By { get; set; }

    public DateTime? TfqAttest2Date { get; set; }

    public string? TfqAttest3Yn { get; set; }

    public string? TfqAttest3By { get; set; }

    public DateTime? TfqAttest3Date { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? PurchaseStatus { get; set; }

    public decimal? ItemVolume { get; set; }

    public string? VolumeUom { get; set; }

    public virtual ICollection<OfferAction> OfferActions { get; } = new List<OfferAction>();

    public virtual ICollection<OfferDocument> OfferDocuments { get; } = new List<OfferDocument>();

    public virtual ICollection<OfferLog> OfferLogs { get; } = new List<OfferLog>();

    public virtual ICollection<OfferPurchaseRequest> OfferPurchaseRequests { get; } = new List<OfferPurchaseRequest>();

    public virtual ICollection<OfferSimulation> OfferSimulations { get; } = new List<OfferSimulation>();
}
