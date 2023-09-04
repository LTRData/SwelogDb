using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SuppInvAttestSimpleInvoice
{
    public string CompanyNo { get; set; } = null!;

    public string AttestCode { get; set; } = null!;

    public string InvoiceType { get; set; } = null!;

    public string ArrivalSeries { get; set; } = null!;

    public decimal ArrivalNo { get; set; }

    public string Preattest1 { get; set; } = null!;

    public string Preattest2 { get; set; } = null!;

    public string FinalAttest { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
