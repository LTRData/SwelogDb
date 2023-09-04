using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu175WithdrawnMfgOrder
{
    public int SerialNumber { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public DateTime? WithdrawnTimestamp { get; set; }
}
