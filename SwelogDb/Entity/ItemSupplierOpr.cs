using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemSupplierOpr
{
    public string ItemNumber { get; set; } = null!;

    public string SupplierId { get; set; } = null!;

    public short OperationNumber { get; set; }

    public string? ArrivalControl { get; set; }

    public short? DeliveryTimeInDays { get; set; }

    public short? TransportTimeInDays { get; set; }

    public string? SupplierClassCode { get; set; }

    public string? SupplierItemDiscountCode { get; set; }

    public decimal? DiscountPercentile { get; set; }

    public string? SupplierHandler { get; set; }

    public short? EarlyDeliveryTolerance { get; set; }

    public short? LateDeliveryTolerance { get; set; }

    public decimal? QtyToleranceAllowed { get; set; }

    public decimal? SupplierGrade { get; set; }

    public string? AuditStamp { get; set; }

    public string? InspectionFlag { get; set; }

    public string? TransferSuggestionYn { get; set; }

    public string? SuppliersDeliveryType { get; set; }

    public string? SuppliersDeliveryPartnerKey { get; set; }

    public string? SuppliersDeliveryDeladdrKey { get; set; }

    public decimal? MinimumPurchaseQuantity { get; set; }

    public string? DrawingNo { get; set; }

    public string? RevisionNo { get; set; }

    public string? SupplierDelAddrId { get; set; }

    public short? DaysForStatus1ToEdi { get; set; }

    public virtual ItemSupplier ItemSupplier { get; set; } = null!;

    public virtual ICollection<ItemSupplierOprPrice> ItemSupplierOprPrices { get; } = new List<ItemSupplierOprPrice>();

    public virtual OperationDtl OperationDtl { get; set; } = null!;
}
