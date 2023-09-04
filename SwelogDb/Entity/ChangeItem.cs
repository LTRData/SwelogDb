using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ChangeItem
{
    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public int? ItemDescriptionTxtid { get; set; }

    public string? ItemDescriptionFlag { get; set; }

    public string? DrawingNo { get; set; }

    public string? RevisionNo { get; set; }

    public string? ProductGroup { get; set; }

    public string? StockingUnit { get; set; }

    public string? ItemType1 { get; set; }

    public string? ItemType2 { get; set; }

    public string? ItemType3 { get; set; }

    public string? MainSupplier { get; set; }

    public short? TurnAroundTime { get; set; }

    public short? MarginTime { get; set; }

    public string? ItemStatus1 { get; set; }

    public string? ItemStatus2 { get; set; }

    public string? ArrivalInspectionIndicator { get; set; }

    public decimal? ItemAnnualRequirement { get; set; }

    public short? InternalLeadTime { get; set; }

    public decimal? MinimumQuantity { get; set; }

    public decimal? MaximumQuantity { get; set; }

    public decimal? ReorderPoint { get; set; }

    public string? LotCode { get; set; }

    public decimal? OrderLotQuantity { get; set; }

    public short? RequirementInWeek { get; set; }

    public decimal? RejectionPercentage { get; set; }

    public decimal? WastagePercentage { get; set; }

    public string? StockLocation { get; set; }

    public string? ProductAccountCode { get; set; }

    public string? AbcCode { get; set; }

    public string? PriceUnit { get; set; }

    public decimal? CostPrice { get; set; }

    public DateTime? LastCostPriceChangeDate { get; set; }

    public decimal? SellingPrice { get; set; }

    public DateTime? LastSellPriceChangeDate { get; set; }

    public decimal? ItemSeperateOrderCost { get; set; }

    public string? ItemDiscountGroupCode { get; set; }

    public decimal? ItemWeight { get; set; }

    public string? WeightUom { get; set; }

    public decimal? ItemVolume { get; set; }

    public string? VolumeUom { get; set; }

    public string? CountryCode { get; set; }

    public string? StatisticsNumber { get; set; }

    public string? EanNumber { get; set; }

    public string? OperationListId { get; set; }

    public string? PlannerId { get; set; }

    public string? BuyerId { get; set; }

    public string? ProductionEngineerId { get; set; }

    public string? QualityEngineerId { get; set; }

    public DateTime? InspectionDocumentDate { get; set; }

    public string? DesignerId { get; set; }

    public decimal? CurrentBalance { get; set; }

    public decimal? ItemReservedQty { get; set; }

    public decimal? PurchaseOrderQuantity { get; set; }

    public decimal? ManufacturingOrderQuantity { get; set; }

    public decimal? BalanceUnderInspection { get; set; }

    public DateTime? LastStocktakingDate { get; set; }

    public DateTime? LastIssueDate { get; set; }

    public DateTime? LastReceiptDate { get; set; }

    public short? LastIssuedLotNo { get; set; }

    public short? LowestLevelInStructure { get; set; }

    public decimal? CurrentPeriodIssue { get; set; }

    public decimal? CurrentYearIssue { get; set; }

    public decimal? LastYearIssue { get; set; }

    public decimal? YearBeforeLastIssue { get; set; }

    public decimal? CurrentPeriodReceipt { get; set; }

    public decimal? CurrentYearReceipt { get; set; }

    public decimal? ItemReceiptLastYear { get; set; }

    public decimal? YearBeforeLastReceipt { get; set; }

    public string? AccountCode { get; set; }

    public string? ItemLabelPrintOption { get; set; }

    public decimal? QuantityPerPallet { get; set; }

    public short? ShelfLifeInDays { get; set; }

    public short? ReactivateLifeInDays { get; set; }

    public string? AuditStamp { get; set; }

    public string? WarehouseId { get; set; }

    public string? LotTrace { get; set; }

    public string? CycleCount { get; set; }

    public string? StockTakingStatus { get; set; }

    public short? PriceUnitNum { get; set; }

    public string? CreateDailyWeeklyDemand { get; set; }

    public int? FrozenPeriod { get; set; }

    public virtual ChangeProductStructureHdr? ChangeProductStructureHdr { get; set; }

    public virtual Country? CountryCodeNavigation { get; set; }

    public virtual ItemStatus1? ItemStatus1Navigation { get; set; }

    public virtual ItemStatus2? ItemStatus2Navigation { get; set; }

    public virtual ItemType1? ItemType1Navigation { get; set; }

    public virtual ItemType2? ItemType2Navigation { get; set; }

    public virtual ItemType3? ItemType3Navigation { get; set; }

    public virtual LotDetail? LotCodeNavigation { get; set; }

    public virtual Supplier? MainSupplierNavigation { get; set; }

    public virtual OperationListHdr? OperationList { get; set; }

    public virtual UnitOfMeasure? PriceUnitNavigation { get; set; }

    public virtual ProductGroup? ProductGroupNavigation { get; set; }

    public virtual UnitOfMeasure? StockingUnitNavigation { get; set; }

    public virtual UnitOfMeasure? VolumeUomNavigation { get; set; }

    public virtual UnitOfMeasure? WeightUomNavigation { get; set; }
}
