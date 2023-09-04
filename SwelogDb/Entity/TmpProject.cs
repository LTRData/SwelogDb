using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpProject
{
    public int ProcessId { get; set; }

    public string ProjectNumber { get; set; } = null!;

    public string? ToolNumber { get; set; }

    public int? LotNumber { get; set; }
}
