using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmEventStatus
{
    public short SerialNumber { get; set; }

    public string? StatusDescription { get; set; }

    public bool? StatusIndicatesFinished { get; set; }
}
