using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PurchaseRequest
{
    public int RowId { get; set; }

    public int? EmploymentNumber { get; set; }

    public string? ReferenceId { get; set; }

    public string? ItemNumber { get; set; }

    public string? ItemDescription { get; set; }

    public decimal? Qty { get; set; }

    public string? Uom { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public decimal? MinimumQuantity { get; set; }

    public decimal? OrderLotQuantity { get; set; }

    public decimal? CurrentBalance { get; set; }

    public decimal? ActualBalance { get; set; }

    public string? FreeText { get; set; }

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public short? OrderLineNumberSub { get; set; }

    public DateTime? PlannedDeliveryDate { get; set; }

    public string? Status { get; set; }

    public string? AuditStamp { get; set; }

    public string? MfgOrderNumber { get; set; }

    public int? MfgLotNumber { get; set; }

    public decimal? CorrectedBalance { get; set; }

    public bool? StockCorrected { get; set; }

    public DateTime? RegDate { get; set; }

    public DateTime? ActionDate { get; set; }

    public decimal? EstimatedPrice { get; set; }
}
