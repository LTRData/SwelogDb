using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpMfgOrder
{
    public int? ProcessId { get; set; }

    public string? ItemLot { get; set; }

    public string? ProjectNumber { get; set; }

    public string? ToolNumber { get; set; }

    public string? ToolPartNumber { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }
}
