using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Territory
{
    public string TerritoryCode { get; set; } = null!;

    public string? TerritoryDesc { get; set; }

    public int? TerritoryDescTxtid { get; set; }

    public string? TerritoryDescFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ContractOrderHeader> ContractOrderHeaders { get; } = new List<ContractOrderHeader>();

    public virtual ICollection<CrmMaster> CrmMasters { get; } = new List<CrmMaster>();

    public virtual ICollection<CustInvoiceHdr> CustInvoiceHdrs { get; } = new List<CustInvoiceHdr>();

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaders { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; } = new List<PurchaseOrderHeader>();

    public virtual ICollection<SystemParameter> SystemParameters { get; } = new List<SystemParameter>();
}
