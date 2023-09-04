using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TempTableMfgOrderPrinting
{
    public int SerialNumber { get; set; }

    public int? ProcessId { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }
}
