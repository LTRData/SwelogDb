using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EuTransportCode
{
    public string EuTransportModeCode { get; set; } = null!;

    public string? EuTransportDescription { get; set; }

    public int? EuTransportCodeTxtid { get; set; }

    public string? EuTransportCodeFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ContractOrderHeader> ContractOrderHeaders { get; } = new List<ContractOrderHeader>();

    public virtual ICollection<CustomerOrderDtl> CustomerOrderDtls { get; } = new List<CustomerOrderDtl>();

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaders { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; } = new List<PurchaseOrderHeader>();

    public virtual ICollection<Supplier> Suppliers { get; } = new List<Supplier>();

    public virtual ICollection<SystemParameter> SystemParameters { get; } = new List<SystemParameter>();
}
