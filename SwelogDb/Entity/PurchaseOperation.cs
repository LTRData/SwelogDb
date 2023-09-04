using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PurchaseOperation
{
    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public int LotNumber { get; set; }

    public short OperationNumber { get; set; }

    public string ResourceNo { get; set; } = null!;

    public string? ResourceDescription { get; set; }

    public decimal? OrderQuantity { get; set; }

    public string? UnitOfMeasure { get; set; }

    public short? UnitConversionFactor { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? QuantityPerPallet { get; set; }

    public short? NumberOfLabel { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public DateTime? DespatchDate { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public decimal? ReceivedQuantity { get; set; }

    public string? SupplierDeliveryNote { get; set; }

    public string? SupplierId { get; set; }

    public string? AuditStamp { get; set; }

    public string? MfgOrderCompleted { get; set; }

    public string? MfgOrderNumber { get; set; }

    public string? OperationDesc { get; set; }

    public decimal? DespatchedQuantity { get; set; }

    public int? MfgOrderSerialKey { get; set; }

    public string? DelplanNo { get; set; }
}
