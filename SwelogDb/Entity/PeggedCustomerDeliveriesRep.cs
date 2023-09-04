using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PeggedCustomerDeliveriesRep
{
    public int ReportId { get; set; }

    public string? ReportName { get; set; }

    public string? CustomerIdList { get; set; }

    public string? AuditStamp { get; set; }
}
