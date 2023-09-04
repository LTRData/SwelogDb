using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BatchMfgOrderHeader
{
    public int SerialNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? RevisionNumber { get; set; }

    public string? FreeCode3 { get; set; }

    public decimal? PlannedQuantity { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<BatchMfgOrderDetail> BatchMfgOrderDetails { get; } = new List<BatchMfgOrderDetail>();
}
