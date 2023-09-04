using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ExecutionLog
{
    public int IdExecutionLog { get; set; }

    public string FunctionId { get; set; } = null!;

    public DateTime? LogDateTime { get; set; }

    public string? LogText { get; set; }

    public string? UserId { get; set; }

    public string? WorkstationId { get; set; }
}
