using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderFunction
{
    public string MannualFunctionId { get; set; } = null!;

    public string? MannualFunctionDescription { get; set; }

    public int? MannualFunctionTxtid { get; set; }

    public string? MannualFunctionFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaders { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<OrderEntryTemplate> OrderEntryTemplates { get; } = new List<OrderEntryTemplate>();

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; } = new List<PurchaseOrderHeader>();
}
