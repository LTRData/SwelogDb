using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DeliveryLabel
{
    public string DeliveryLabelId { get; set; } = null!;

    public string? GoodsMark { get; set; }

    public string? GoodsFormatDefinition { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<CustomerOrderDtl> CustomerOrderDtls { get; } = new List<CustomerOrderDtl>();

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaders { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

    public virtual ICollection<PurchaseOrderDtl> PurchaseOrderDtls { get; } = new List<PurchaseOrderDtl>();

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; } = new List<PurchaseOrderHeader>();
}
