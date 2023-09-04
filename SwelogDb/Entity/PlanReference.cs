using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PlanReference
{
    public short PlanTransactionNo { get; set; }

    public string? PlanTransactionDesc { get; set; }

    public string? MultilingualCode { get; set; }

    public string? AuditStamp { get; set; }
}
