using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SuppInvAttestUser
{
    public int RecNo { get; set; }

    public string? AssignedFromUserid { get; set; }

    public string? AssignedToUserid { get; set; }

    public string? CompanyNo { get; set; }

    public string? InvoiceType { get; set; }

    public string? ArrivalSeries { get; set; }

    public decimal? ArrivalNo { get; set; }

    public string? Status { get; set; }

    public string? ErrorText { get; set; }

    public DateTime? EventDate { get; set; }

    public string? AuditStamp { get; set; }

    public string? Inactive { get; set; }
}
