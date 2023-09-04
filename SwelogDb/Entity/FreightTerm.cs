using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class FreightTerm
{
    public string FreightTermsCode { get; set; } = null!;

    public string? FreightTermsDesc { get; set; }

    public int? FreightTermsDescTxtid { get; set; }

    public string? FreightTermsDescFlag { get; set; }

    public decimal? FrieghtCharges { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ContractOrderHeader> ContractOrderHeaders { get; } = new List<ContractOrderHeader>();

    public virtual ICollection<CustInvoiceHdr> CustInvoiceHdrs { get; } = new List<CustInvoiceHdr>();

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaders { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; } = new List<PurchaseOrderHeader>();

    public virtual ICollection<Supplier> Suppliers { get; } = new List<Supplier>();
}
