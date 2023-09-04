using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class InterestPaymentTerm
{
    public string IntInvoicePaymentTermCode { get; set; } = null!;

    public decimal? IntInvPayTermDays { get; set; }

    public string? IntInvPayTermDesc { get; set; }

    public int? InterestInvoicePayTxtid { get; set; }

    public string? InterestInvoicePayFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaders { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; } = new List<PurchaseOrderHeader>();

    public virtual ICollection<SystemParameter> SystemParameters { get; } = new List<SystemParameter>();
}
