using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderItemType
{
    public string OrderItemType1 { get; set; } = null!;

    public string? OrderItemDescription { get; set; }

    public int? OrderItemTxtid { get; set; }

    public string? OrderItemFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaders { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

    public virtual ICollection<OrderEntryTemplate> OrderEntryTemplates { get; } = new List<OrderEntryTemplate>();

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; } = new List<PurchaseOrderHeader>();
}
