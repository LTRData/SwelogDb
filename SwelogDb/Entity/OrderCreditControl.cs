using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderCreditControl
{
    public string OrderCreditControlCode { get; set; } = null!;

    public string? OrderCreditControlDesc { get; set; }

    public int? OrderCreditControlTxtid { get; set; }

    public string? OrderCreditControlFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaders { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<OrderEntryTemplate> OrderEntryTemplates { get; } = new List<OrderEntryTemplate>();

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; } = new List<PurchaseOrderHeader>();
}
