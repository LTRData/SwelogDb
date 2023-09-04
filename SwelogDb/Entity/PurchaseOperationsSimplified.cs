using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PurchaseOperationsSimplified
{
    public int SerialNumber { get; set; }

    public int DeliveryNoteNumber { get; set; }

    public string SupplierId { get; set; } = null!;

    public int ActivityNumber { get; set; }

    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public int OperationNumber { get; set; }

    public decimal? DeliveredQuantity { get; set; }

    public DateTime? PlannedDeliveryDate { get; set; }

    public DateTime? DispatchDate { get; set; }

    public string? DeliveryAddressId { get; set; }

    public string? OurDeliveryAddressId { get; set; }

    public string? CreatedBy { get; set; }

    public int? EmploymentNumber { get; set; }

    public DateTime? LastPrintedDate { get; set; }

    public string? LastPrintedBy { get; set; }

    public string? Status { get; set; }

    public decimal? QuantityReceived { get; set; }

    public string? SupplierDeliveryAddress { get; set; }

    public string? Resource { get; set; }

    public int? IdPurchaseOrderDtl { get; set; }
}
