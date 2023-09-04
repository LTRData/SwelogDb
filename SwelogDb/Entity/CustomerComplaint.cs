using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerComplaint
{
    public int RecNo { get; set; }

    public string ComplaintNo { get; set; } = null!;

    public string? WarehouseId { get; set; }

    public string? CustomerId { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public string? ItemNumber { get; set; }

    public decimal? RejectedQty { get; set; }

    public string? NotApproveCode { get; set; }

    public DateTime? ReportDate { get; set; }

    public string? ComplaintDetails { get; set; }

    public string? ComplaintFilePath { get; set; }

    public string? Status { get; set; }

    public string? ErrorReportId { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? QtyReviewed { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public string? DeliveryAddressId { get; set; }

    public decimal? DeliveryQuantity { get; set; }

    public string? UnitOfSale { get; set; }
}
