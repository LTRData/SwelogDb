using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PfmeaAp
{
    public int IdPfmeaAp { get; set; }

    public short? SLow { get; set; }

    public short? SHigh { get; set; }

    public short? OLow { get; set; }

    public short? OHigh { get; set; }

    public short? DLow { get; set; }

    public short? DHigh { get; set; }

    public string? Ap { get; set; }

    public string? AuditStamp { get; set; }
}
