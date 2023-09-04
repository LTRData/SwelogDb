using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgOrderItemCopy
{
    public int SerialNumber { get; set; }

    public string? SourceItemNumber { get; set; }

    public string? DestinationItemNumber { get; set; }

    public string? AuditStamp { get; set; }
}
