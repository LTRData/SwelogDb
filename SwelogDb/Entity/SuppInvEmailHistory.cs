using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SuppInvEmailHistory
{
    public int RecNo { get; set; }

    public string? EmailIdFrom { get; set; }

    public string? EmailIdTo { get; set; }

    public string? Comments { get; set; }

    public string? CompanyNo { get; set; }

    public string? InvoiceType { get; set; }

    public string? ArrivalSeries { get; set; }

    public decimal? ArrivalNo { get; set; }

    public DateTime? Timestamp { get; set; }

    public string? AuditStamp { get; set; }
}
