using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NrpMfgOperationDtl
{
    public string OperationList { get; set; } = null!;

    public short OperationNumber { get; set; }

    public DateTime? MfgOperationStartTime { get; set; }

    public DateTime? MfgOperationEndTime { get; set; }
}
