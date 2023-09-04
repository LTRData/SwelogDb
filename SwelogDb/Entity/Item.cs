using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Item
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

    public string? ExtraItemDescription { get; set; }

    public string? FreeCode1 { get; set; }

    public string? FreeCode2 { get; set; }

    public string? FreeCode3 { get; set; }

    public string? StockPosition { get; set; }

    public decimal? CalculatedPrice { get; set; }

    public int? VariantFree { get; set; }

    public string? DeliveryTimeId { get; set; }

    public string? QuantityRatingId { get; set; }

    public string? ProdpropGroup { get; set; }

    public string? PalletFlag { get; set; }

    public bool? ShowInHome { get; set; }

    public int? NoOfVisits { get; set; }

    public string? HotFlag { get; set; }

    public decimal? SellingPriceWithVat { get; set; }

    public string? OwnerType { get; set; }

    public string? PackingType { get; set; }

    public string? MainLeasingPartner { get; set; }

    public string? ReferenceProjectNumber { get; set; }

    public string? PurchOverheadPercentCode { get; set; }

    public decimal? QuantityPerPacket { get; set; }

    public int? AlloyIndicator { get; set; }

    public string? Quality { get; set; }

    public decimal? Thickness { get; set; }

    public string? ThicknessUom { get; set; }

    public decimal? Breadth { get; set; }

    public string? BreadthUom { get; set; }

    public decimal? Length { get; set; }

    public string? LengthUom { get; set; }

    public string? ColorDescription { get; set; }

    public decimal? Density { get; set; }

    public string? DensityUom { get; set; }

    public string? PackageEan { get; set; }

    public decimal? QuantityInPackage { get; set; }

    public string? TransportPackageEan { get; set; }

    public decimal? QuantityInTransportPackage { get; set; }

    public string? ColorCode { get; set; }

    public int? SetupsPerYear { get; set; }

    public decimal? CalculatedPriceForecast { get; set; }

    public DateTime? CalcPriceChangeDate { get; set; }

    public DateTime? CalcPriceForcChangeDate { get; set; }

    public string? AlloyCode { get; set; }

    public string? ScrapCode { get; set; }

    public int? ScrapIndicator { get; set; }

    public decimal? Area { get; set; }

    public string? AreaUom { get; set; }

    public decimal? SellingPricePerArea { get; set; }

    public decimal? SellingPricePerAreaWithVat { get; set; }

    public string? ProductNo { get; set; }

    public decimal? PurchaseOrderSetupPrice { get; set; }

    public string? BreadthCu204Yn { get; set; }

    public string? DonotUpdateCostprice { get; set; }

    public string? VehicleTypeId { get; set; }

    public string? ModelId { get; set; }

    public decimal? MinimumPurchaseQuantity { get; set; }

    public string? DeliverFullPallet { get; set; }

    public decimal? Cu251ProfitOh { get; set; }

    public short? NoOfWeeksForSecurityStockCalc { get; set; }

    public decimal? SpeccostMatfreight { get; set; }

    public decimal? SpeccostPurchoprfreightEu { get; set; }

    public decimal? SpeccostPurchoprfreightSv { get; set; }

    public decimal? SpeccostCustfreight { get; set; }

    public decimal? SpeccostRework { get; set; }

    public decimal? SpeccostRejection { get; set; }

    public decimal? SpeccostToolservice { get; set; }

    public decimal? Height { get; set; }

    public string? HeightUom { get; set; }

    public decimal? Depth { get; set; }

    public string? DepthUom { get; set; }

    public decimal? Diameter { get; set; }

    public string? DiameterUom { get; set; }

    public decimal? SpeccostSetup { get; set; }

    public decimal? SpeccostOther { get; set; }

    public string? Autosys { get; set; }

    public string? SellingPriceExchangeCurrency { get; set; }

    public decimal? SellingPriceExchangeRate { get; set; }

    public string? CostPriceExchangeCurrency { get; set; }

    public decimal? CostPriceExchangeRate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? TimesetAfterStart { get; set; }

    public string? UpdFromPriceListId { get; set; }

    public decimal? TransportPackageTareWeight { get; set; }

    public string? PurchaseCurrencyCode { get; set; }

    public decimal? PurchasePriceFc { get; set; }

    public string? AdditionalItemDescription { get; set; }

    public decimal? OfferPriceReductionPercent { get; set; }

    public DateTime? CustfreightChangeDate { get; set; }

    public string? StoreOwnersItemNo { get; set; }

    public int? OrderLotMultiple { get; set; }

    public decimal? ContributionMargin1 { get; set; }

    public decimal? ContributionMargin2 { get; set; }

    public string? SegmentId { get; set; }

    public string? ProductType { get; set; }

    public decimal? AlloyCostPrice { get; set; }

    public decimal? AlloySellingPrice { get; set; }

    public string? DefaultLocForDelToCust { get; set; }

    public string? ReplacementItemNo { get; set; }

    public int? DaysForStatus1ToEdi { get; set; }

    public string? EcnNumber { get; set; }

    public decimal? TotaccumComponentCost { get; set; }

    public decimal? TotaccumWagecost { get; set; }

    public decimal? TotaccumOther { get; set; }

    public decimal? TotaccumAlloyCost { get; set; }

    public DateTime? LastEcnChangeDate { get; set; }

    public decimal? FixedUsage { get; set; }

    public int? DaysForStatus3ToEdi { get; set; }

    public string? FreeCode4 { get; set; }

    public decimal? MinSaleQty { get; set; }

    public virtual Color? ColorCodeNavigation { get; set; }

    public virtual Country? CountryCodeNavigation { get; set; }

    public virtual ICollection<CurrentDeliveryPlanHdr> CurrentDeliveryPlanHdrs { get; } = new List<CurrentDeliveryPlanHdr>();

    public virtual ICollection<CustomerArticle> CustomerArticles { get; } = new List<CustomerArticle>();

    public virtual ICollection<ItemMarketPrice> ItemMarketPrices { get; } = new List<ItemMarketPrice>();

    public virtual ICollection<ItemPackingInstruction> ItemPackingInstructions { get; } = new List<ItemPackingInstruction>();

    public virtual ICollection<ItemRelationship> ItemRelationshipChildItemNumberNavigations { get; } = new List<ItemRelationship>();

    public virtual ICollection<ItemRelationship> ItemRelationshipItemNumberNavigations { get; } = new List<ItemRelationship>();

    public virtual ICollection<ItemSearch> ItemSearches { get; } = new List<ItemSearch>();

    public virtual ItemStatus1? ItemStatus1Navigation { get; set; }

    public virtual ItemStatus2? ItemStatus2Navigation { get; set; }

    public virtual ICollection<ItemSupplierText> ItemSupplierTexts { get; } = new List<ItemSupplierText>();

    public virtual ICollection<ItemSupplier> ItemSuppliers { get; } = new List<ItemSupplier>();

    public virtual ItemType1? ItemType1Navigation { get; set; }

    public virtual ItemType2? ItemType2Navigation { get; set; }

    public virtual ItemType3? ItemType3Navigation { get; set; }

    public virtual ICollection<KitItemTable> KitItemTables { get; } = new List<KitItemTable>();

    public virtual LotDetail? LotCodeNavigation { get; set; }

    public virtual Supplier? MainSupplierNavigation { get; set; }

    public virtual ICollection<ManufacturingProgramDtl> ManufacturingProgramDtls { get; } = new List<ManufacturingProgramDtl>();

    public virtual OperationListHdr? OperationList { get; set; }

    public virtual ICollection<PackingType> PackingTypes { get; } = new List<PackingType>();

    public virtual ICollection<PriceListDetail> PriceListDetails { get; } = new List<PriceListDetail>();

    public virtual UnitOfMeasure? PriceUnitNavigation { get; set; }

    public virtual ProductGroup? ProductGroupNavigation { get; set; }

    public virtual ICollection<SearchItemValue> SearchItemValues { get; } = new List<SearchItemValue>();

    public virtual UnitOfMeasure? StockingUnitNavigation { get; set; }

    public virtual ICollection<StructureVariantItem> StructureVariantItems { get; } = new List<StructureVariantItem>();

    public virtual ICollection<SupplierItem> SupplierItems { get; } = new List<SupplierItem>();

    public virtual ICollection<ToolHeader> ToolHeaders { get; } = new List<ToolHeader>();

    public virtual UnitOfMeasure? VolumeUomNavigation { get; set; }

    public virtual UnitOfMeasure? WeightUomNavigation { get; set; }
}
