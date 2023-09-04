using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DocumentEvent
{
    public int SerialNumber { get; set; }

    public string? EventName { get; set; }

    public string? PreferredEventName { get; set; }
}
