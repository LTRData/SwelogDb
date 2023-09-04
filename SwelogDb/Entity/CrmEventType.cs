using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmEventType
{
    public short SerialNumber { get; set; }

    public string? EventTypeDescription { get; set; }
}
