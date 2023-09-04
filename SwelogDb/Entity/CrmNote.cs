using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmNote
{
    public int SerialNumber { get; set; }

    public int ContactSerialNumber { get; set; }

    public string? Notes { get; set; }
}
