using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerOrderDtl
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public DateTime PlannedDeliveryDate { get; set; }

    public string DeliveryAddressId { get; set; } = null!;

    public string? OrderLineType { get; set; }

    public string? ItemNumber { get; set; }

    public string? GoodsDescription { get; set; }

    public int? GoodsDescriptionTxtid { get; set; }

    public string? GoodsDescriptionFlag { get; set; }

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

    public string? UsageCode { get; set; }

    public decimal? SetupPrice { get; set; }

    public string? VatCode { get; set; }

    public string? SupplierId { get; set; }

    public string? DirectDeliveryFlag { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public string? TransportModeCode { get; set; }

    public string? WarehouseId { get; set; }

    public string? DeliveryTermsCode { get; set; }

    public string? DeliveryLabelId { get; set; }

    public short? ScheduleConfirmInDays { get; set; }

    public short? SupplierMaterialInDays { get; set; }

    public decimal? ActualDeliveredQuantity { get; set; }

    public DateTime? LastDeliveredDate { get; set; }

    public string? EuLabourCode { get; set; }

    public string? EuTransportCode { get; set; }

    public string? ConfigurableItemInd { get; set; }

    public string? GoodsMarking { get; set; }

    public string? DeliveryStatus { get; set; }

    public string? AuditStamp { get; set; }

    public string? AccountNo { get; set; }

    public string? DepartmentNo { get; set; }

    public string? ProductNo { get; set; }

    public string? ProjectNo { get; set; }

    public string? FunctionNo { get; set; }

    public string? ANo { get; set; }

    public string? BNo { get; set; }

    public string? CNo { get; set; }

    public string? DNo { get; set; }

    public string? AccountKeyFlag { get; set; }

    public string? SupplierItemNumber { get; set; }

    public string? ItemTextFlag { get; set; }

    public short? PriceUnit { get; set; }

    public string? OrderLineStatus { get; set; }

    public short? PoOrderLine { get; set; }

    public decimal? DiscountPercentage2 { get; set; }

    public string? StoreLocation { get; set; }

    public decimal? NoOfPackets { get; set; }

    public string? MfgOrderNumber { get; set; }

    public int? MfgLotNumber { get; set; }

    public string? EdiCustomerItemNo { get; set; }

    public string? EdiCustomerEanItemNo { get; set; }

    public int? EdiOrderLineNo { get; set; }

    public decimal? EdiOrderQuantity { get; set; }

    public decimal? EdiPricePerUnit { get; set; }

    public DateTime? EdiRequestedDeliveryDate { get; set; }

    public decimal? Area { get; set; }

    public string? AreaUom { get; set; }

    public decimal? SellingPricePerArea { get; set; }

    public string? BlockOrderNumber { get; set; }

    public string? FullyDeliver { get; set; }

    public string? SplittedLine { get; set; }

    public string? SplitLine { get; set; }

    public string? InternalComments { get; set; }

    public string? AdvanceInvSeries { get; set; }

    public decimal? AdvanceInvNo { get; set; }

    public decimal? AheadTime { get; set; }

    public string? Pos { get; set; }

    public string? Marke { get; set; }

    public string? LineConfirmed { get; set; }

    public string? PrintFlag { get; set; }

    public string? OrderCategory { get; set; }

    public string? GoodsMarking2 { get; set; }

    public string? DoNotIncludeInIntrastat { get; set; }

    public string? RotWithdraw { get; set; }

    public string? OrderLineApproved { get; set; }

    public string? ConfirmedFrom { get; set; }

    public virtual DeliveryLabel? DeliveryLabel { get; set; }

    public virtual EuTransportCode? EuTransportCodeNavigation { get; set; }

    public virtual ItemDiscountGroup? ItemDiscountGroupCodeNavigation { get; set; }

    public virtual CustomerOrderHeader Order { get; set; } = null!;

    public virtual Warehouse? Warehouse { get; set; }
}
