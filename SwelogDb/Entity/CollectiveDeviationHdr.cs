using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CollectiveDeviationHdr
{
    public DateTime DivergentDate { get; set; }

    public string? DivergentDateDescription { get; set; }

    public string? AuditStamp { get; set; }
}
