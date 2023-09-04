using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderDocument
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public string OrderDocumentsId { get; set; } = null!;

    public DateTime? OrderDocumentsDate { get; set; }

    public string? OrderDocumentsReference { get; set; }

    public string? AuditStamp { get; set; }

    public string? CopyFlag { get; set; }

    public string DocumentNumber { get; set; } = null!;

    public decimal? Amount { get; set; }

    public string? UserId { get; set; }

    public string? InvEfaktFlag { get; set; }

    public string? Details { get; set; }

    public string? FilePath { get; set; }
}
