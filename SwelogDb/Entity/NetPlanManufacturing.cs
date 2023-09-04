using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NetPlanManufacturing
{
    public int NetPlanId { get; set; }

    public short SequenceNumber { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public decimal? DerivedOrderQty { get; set; }

    public DateTime? MfgOrderStartDate { get; set; }

    public DateTime? MfgOrderDueDate { get; set; }

    public string? AuditStamp { get; set; }
}
