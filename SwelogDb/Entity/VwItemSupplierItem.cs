using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwItemSupplierItem
{
    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public string? ProductGroup { get; set; }

    public string? StockingUnit { get; set; }

    public string? ItemType1 { get; set; }

    public string? ItemType2 { get; set; }

    public string? ItemType3 { get; set; }

    public string? MainSupplier { get; set; }

    public string? ItemStatus1 { get; set; }

    public string? ItemStatus2 { get; set; }

    public string? ArrivalInspectionIndicator { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? ItemSellingPrice { get; set; }

    public decimal? ItemSeperateOrderCost { get; set; }

    public string? PlannerId { get; set; }

    public decimal? SellingPriceWithVat { get; set; }

    public short? ItemPriceUnitNum { get; set; }

    public string SupplierItemNumber { get; set; } = null!;

    public string? SupplierItemDescription { get; set; }

    public string? SupplierUom { get; set; }

    public string? ArrivalControl { get; set; }

    public short? DeliveryTimeInDays { get; set; }

    public short? TransportTimeInDays { get; set; }

    public string? SupplierItemClassCode { get; set; }

    public decimal? DiscountPercentile { get; set; }

    public string? PreferedItem { get; set; }

    public decimal? SupplierItemGrade { get; set; }

    public string SupplierId { get; set; } = null!;

    public string? SupplierName { get; set; }

    public string? SupplierStatusCode { get; set; }

    public string? SupplierClassCode { get; set; }

    public decimal? SupplierGrade { get; set; }

    public string? OurReference { get; set; }

    public string? LanguageCode { get; set; }

    public string? CurrencyCode { get; set; }

    public string? EuCountryCode { get; set; }

    public DateTime SupplierPriceValidFrom { get; set; }

    public decimal? SellingPrice { get; set; }

    public decimal? SetUpCost { get; set; }

    public decimal? ExtraCostEstimate { get; set; }

    public decimal? ExtraCostEstimatePercent { get; set; }

    public short? PriceUnitNum { get; set; }

    public DateTime? SupplierPriceValidTo { get; set; }

    public string CurrentPriceYn { get; set; } = null!;
}
