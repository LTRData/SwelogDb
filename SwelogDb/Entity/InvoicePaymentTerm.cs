using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class InvoicePaymentTerm
{
    public string PaymentTermCode { get; set; } = null!;

    public decimal? InvPayTermDays { get; set; }

    public string? InvPayTermDesc { get; set; }

    public int? InvPayTermDescTxtid { get; set; }

    public string? InvPayTermDescFlag { get; set; }

    public string? CashDiscountOption { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? ServiceChargePercentage { get; set; }

    public string? CustomerId { get; set; }

    public string? AdvanceInvoice { get; set; }

    public virtual ICollection<ContractOrderHeader> ContractOrderHeaders { get; } = new List<ContractOrderHeader>();

    public virtual ICollection<CustInvoiceHdr> CustInvoiceHdrs { get; } = new List<CustInvoiceHdr>();

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaders { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; } = new List<PurchaseOrderHeader>();

    public virtual ICollection<SystemParameter> SystemParameters { get; } = new List<SystemParameter>();
}
