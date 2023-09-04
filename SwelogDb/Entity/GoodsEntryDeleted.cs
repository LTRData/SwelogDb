using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class GoodsEntryDeleted
{
    public string GoodsentryNo { get; set; } = null!;

    public DateTime ArrivalDate { get; set; }

    public string? ItemNumber { get; set; }

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public short? OrderLineNumberSub { get; set; }

    public DateTime? PlannedDeliveryDate { get; set; }

    public string? DeliveryAddressId { get; set; }

    public int? ManufacturingLotNumber { get; set; }

    public short? OperationNumber { get; set; }

    public decimal? DeliveryQty { get; set; }

    public decimal? InspectedQty { get; set; }

    public decimal? ApprovedQty { get; set; }

    public string? DeliveryStatus { get; set; }

    public string? InspectionStatus { get; set; }

    public string? WarehouseId { get; set; }

    public string? StockYard { get; set; }

    public string? DeliveryNoteNo { get; set; }

    public string? AuditStamp { get; set; }

    public string? InvoiceFlag { get; set; }

    public decimal? ConversionFactor { get; set; }

    public string? CustomerOrderNumber { get; set; }

    public string? ProjectNumber { get; set; }

    public string? SupplierId { get; set; }

    public decimal? PurchasePrice { get; set; }

    public string? CurrencyCode { get; set; }

    public int? PriceUnit { get; set; }

    public decimal? SetupPrice { get; set; }

    public string? ArrivalSeries { get; set; }

    public decimal? ArrivalNo { get; set; }

    public decimal? PurchasePriceFc { get; set; }

    public decimal? SetupPriceFc { get; set; }

    public decimal? BalanceBeforeGoodsentry { get; set; }

    public decimal? CostpriceAfterGoodsentry { get; set; }

    public decimal? CostpriceAfterInvoice { get; set; }

    public decimal? OrderLineDiscount { get; set; }

    public decimal? OrderDiscount { get; set; }

    public decimal? AlloySurchargeFc { get; set; }

    public decimal? AlloySurchargeBc { get; set; }

    public string? CertificateDesc { get; set; }

    public int? IdPurchaseOrderDtl { get; set; }

    public string? PackageYn { get; set; }

    public string? ArrivalInspectionIndicator { get; set; }

    public string? PalletLabelYn { get; set; }

    public decimal? BreadthCu204 { get; set; }

    public decimal? OrderQtyPurchUnit { get; set; }

    public decimal? DeliveryQtyPurchUnit { get; set; }

    public string? PurchUnit { get; set; }

    public decimal? StockTransactionValue { get; set; }

    public decimal? OtherCostsFc { get; set; }

    public decimal? OtherCostsBc { get; set; }

    public string? InvoiceNotExpectedYn { get; set; }

    public decimal? DeliveryPart { get; set; }

    public decimal? FcToBcFactor { get; set; }

    public string? OurReference { get; set; }

    public int? LabelsPerPallet { get; set; }

    public string? OrderLineType { get; set; }

    public DateTime? ProcessDatetime { get; set; }

    public string? ControlId { get; set; }

    public string? DoNotIncludeInIntrastat { get; set; }

    public string? PartnerOrderNumber { get; set; }

    public DateTime? DespatchDate { get; set; }

    public DateTime? AvailableDate { get; set; }
}
