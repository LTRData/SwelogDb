using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DeliveryTerm
{
    public string DeliveryTermsCode { get; set; } = null!;

    public string? DeliveryTermDescription { get; set; }

    public int? DeliveryTermDescTxtid { get; set; }

    public string? DeliveryTermDescFlag { get; set; }

    public string? AuditStamp { get; set; }

    public string? ShowTranspCustInPo { get; set; }

    public string? UnifaunParid { get; set; }

    public string? UnifaunDeliveryTermCode { get; set; }

    public string? TransportModeCode { get; set; }

    public virtual ICollection<ContractOrderHeader> ContractOrderHeaders { get; } = new List<ContractOrderHeader>();

    public virtual ICollection<CustInvoiceHdr> CustInvoiceHdrs { get; } = new List<CustInvoiceHdr>();

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaders { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; } = new List<PurchaseOrderHeader>();

    public virtual ICollection<Supplier> Suppliers { get; } = new List<Supplier>();

    public virtual ICollection<SystemParameter> SystemParameters { get; } = new List<SystemParameter>();
}
