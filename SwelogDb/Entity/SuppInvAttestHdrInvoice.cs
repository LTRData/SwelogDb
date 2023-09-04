using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SuppInvAttestHdrInvoice
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string AccountNo { get; set; } = null!;

    public string DepartmentNo { get; set; } = null!;

    public string InvoiceType { get; set; } = null!;

    public string ArrivalSeries { get; set; } = null!;

    public decimal ArrivalNo { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<SuppInvAttestDtlInvoice> SuppInvAttestDtlInvoices { get; } = new List<SuppInvAttestDtlInvoice>();
}
