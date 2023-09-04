using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MosExecutionLog
{
    public string OrderNumber { get; set; } = null!;

    public string? LastExecutionUserid { get; set; }

    public DateTime? CalculationStarted { get; set; }

    public DateTime? CalculationEnded { get; set; }

    public string? CalculationStatus { get; set; }
}
