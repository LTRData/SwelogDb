using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpLeadTime
{
    public int? ProcessId { get; set; }

    public string? ParentPart { get; set; }

    public string? ComponentPart { get; set; }

    public int? OperationNumber { get; set; }

    public int? ComponentLeadTime { get; set; }

    public int? OperationLeadTime { get; set; }

    public decimal? OperationTime { get; set; }

    public string? LoadString { get; set; }

    public int? ItemLeadTime { get; set; }
}
