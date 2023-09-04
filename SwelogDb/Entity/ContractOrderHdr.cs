using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ContractOrderHdr
{
    public string PurchaseOrderNumber { get; set; } = null!;

    public string? SupplierId { get; set; }

    public DateTime? PurchaseOrderDate { get; set; }

    public string? SupplierReference { get; set; }

    public string? OurReference { get; set; }

    public int? PurchaseOrderAccountNumber { get; set; }

    public string? OurCustomerOrderNumber { get; set; }

    public string? SupplierOwnOrderNumber { get; set; }

    public string? PurOrderAcknowledgeFlag { get; set; }

    public DateTime? PurchaseOrderAcknowledgDate { get; set; }

    public string? FinalDeliveryFlag { get; set; }

    public DateTime? PurchaseOrderPrintDate { get; set; }

    public string? PurchaseImportCode { get; set; }

    public string? OrderBlockingStatus { get; set; }

    public string? BuyerId { get; set; }

    public DateTime? BuyerIdValidFrom { get; set; }

    public string? OurAggrementHandlerId { get; set; }

    public string? SupplierHandlerId { get; set; }

    public string? AuditStamp { get; set; }
}
