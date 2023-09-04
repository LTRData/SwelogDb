using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SuppInvHdrXmlUser
{
    public int RecNo { get; set; }

    public string? AssignedToUserid { get; set; }

    public string? CompanyNo { get; set; }

    public string? InvoiceType { get; set; }

    public string? ArrivalSeries { get; set; }

    public decimal? ArrivalNo { get; set; }

    public string? Status { get; set; }

    public string? AuditStamp { get; set; }
}
