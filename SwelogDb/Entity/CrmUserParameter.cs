using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmUserParameter
{
    public int RecNo { get; set; }

    public string? AllowTemporaryCustomers { get; set; }

    public string? AuditStamp { get; set; }

    public string? AlwaysShowInMaximizedMode { get; set; }

    public string? OrderComparisionGraph { get; set; }

    public int? ToDeliverWithinDays { get; set; }

    public int? DeliveredWithinDays { get; set; }

    public string? ShowFullyDelvdOrders { get; set; }
}
