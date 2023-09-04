using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PurchaseOrderDtl
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public DateTime PlannedDeliveryDate { get; set; }

    public string DeliveryAddressId { get; set; } = null!;

    public string? OrderLineType { get; set; }

    public string? ItemNumber { get; set; }

    public short? OperationNumber { get; set; }

    public string? GoodsDescription { get; set; }

    public int? GoodsDescriptionTxtid { get; set; }

    public string? GoodsDescriptionFlag { get; set; }

    public string? ContractOrderNumber { get; set; }

    public decimal? OrderQuantity { get; set; }

    public string? UnitOfSale { get; set; }

    public string? ItemNumberGenerated { get; set; }

    public decimal? QuantityGenerated { get; set; }

    public string? UnitOfStock { get; set; }

    public DateTime? DesiredDeliveryDate { get; set; }

    public DateTime? PromisedDeliveryDate { get; set; }

    public decimal? SellingPrice { get; set; }

    public decimal? OrderedAmount { get; set; }

    public string? ItemDiscountGroupCode { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public decimal? FreeQuantity { get; set; }

    public string? ItemAccountCode { get; set; }

    public decimal? CostPrice { get; set; }

    public string? SupplierId { get; set; }

    public string? DirectDeliveryFlag { get; set; }

    public string? WarehouseId { get; set; }

    public string? DeliveryTermsCode { get; set; }

    public string? DeliveryLabelId { get; set; }

    public string? TransportModeCode { get; set; }

    public short? ManufacturingLotNumber { get; set; }

    public string? UsageCode { get; set; }

    public decimal? SetupPrice { get; set; }

    public short? ScheduleConfirmInDays { get; set; }

    public short? SupplierMaterialInDays { get; set; }

    public decimal? ActualDeliveredQuantity { get; set; }

    public DateTime? LastDeliveredDate { get; set; }

    public string? VatCode { get; set; }

    public string? EuLabourCode { get; set; }

    public string? EuTransportCode { get; set; }

    public string? ConfigurableItemInd { get; set; }

    public string? GoodsMarking { get; set; }

    public string? DeliveryStatus { get; set; }

    public string? AuditStamp { get; set; }

    public string? SupplierItemNumber { get; set; }

    public short? PriceUnit { get; set; }

    public string? CustomerOrderNumber { get; set; }

    public string? ProjectNumber { get; set; }

    public DateTime? AvailableDate { get; set; }

    public decimal? DeliveredStockUnits { get; set; }

    public string? MfgOrderNumber { get; set; }

    public string? MfgItemNumber { get; set; }

    public string? DepartmentNo { get; set; }

    public string? InternalGoodsReceiver { get; set; }

    public string? ProductNo { get; set; }

    public string? ProjectNo { get; set; }

    public string? FunctionNo { get; set; }

    public string? CostAccountCode { get; set; }

    public string? ProductGroup { get; set; }

    public short? CoOrderLine { get; set; }

    public string? ANo { get; set; }

    public string? BNo { get; set; }

    public string? CNo { get; set; }

    public string? DNo { get; set; }

    public string? CreateCodeStrFromOrder { get; set; }

    public string? OrderLineStatus { get; set; }

    public decimal? AlloySurchargeFc { get; set; }

    public int IdPurchaseOrderDtl { get; set; }

    public string? PartnerOrderNumber { get; set; }

    public decimal? StockReceivedQty { get; set; }

    public decimal? QtyInInspection { get; set; }

    public string? DrawingNo { get; set; }

    public string? RevisionNo { get; set; }

    public decimal? QtyReturned { get; set; }

    public string? DelStatus { get; set; }

    public string? SupplierDelAddrId { get; set; }

    public string? DeliveryAtSupplierYn { get; set; }

    public DateTime? DeliveryAtSupplierPromisedDate { get; set; }

    public DateTime? DeliveryAtSupplierDeliveredDate { get; set; }

    public string? PuchoprDirectdelType { get; set; }

    public string? PuchoprDirectdelPartnerId { get; set; }

    public string? PuchoprDirectdelDeladdr { get; set; }

    public string? DoNotIncludeInIntrastat { get; set; }

    public int? PartId { get; set; }

    public string? EcnNumber { get; set; }

    public string? InternalComments { get; set; }

    public virtual DeliveryLabel? DeliveryLabel { get; set; }

    public virtual ItemDiscountGroup? ItemDiscountGroupCodeNavigation { get; set; }

    public virtual PurchaseOrderHeader Order { get; set; } = null!;

    public virtual Warehouse? Warehouse { get; set; }
}
