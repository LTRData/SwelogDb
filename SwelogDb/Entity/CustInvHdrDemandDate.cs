using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustInvHdrDemandDate
{
    public string CompanyNo { get; set; } = null!;

    public string InvoiceType { get; set; } = null!;

    public string InvoiceSeries { get; set; } = null!;

    public decimal InvoiceNo { get; set; }

    public int DemandNo { get; set; }

    public DateTime? DemandDate { get; set; }

    public string? AuditStamp { get; set; }

    public virtual CustInvHdr CustInvHdr { get; set; } = null!;
}
