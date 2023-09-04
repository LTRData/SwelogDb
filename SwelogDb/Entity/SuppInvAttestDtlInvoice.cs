using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SuppInvAttestDtlInvoice
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string AccountNo { get; set; } = null!;

    public string DepartmentNo { get; set; } = null!;

    public string InvoiceType { get; set; } = null!;

    public string ArrivalSeries { get; set; } = null!;

    public decimal ArrivalNo { get; set; }

    public string Purchaser { get; set; } = null!;

    public string Preattest1 { get; set; } = null!;

    public string Preattest2 { get; set; } = null!;

    public string FinalAttest { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual SuppInvAttestHdrInvoice SuppInvAttestHdrInvoice { get; set; } = null!;
}
