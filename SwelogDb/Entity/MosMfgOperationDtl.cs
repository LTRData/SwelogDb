using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MosMfgOperationDtl
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public short OperationNumber { get; set; }

    public DateTime? MfgOperationStartTime { get; set; }

    public DateTime? MfgOperationEndTime { get; set; }
}
