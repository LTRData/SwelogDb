using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PoSuggestExecutionLog
{
    public int IdPoSuggestExecutionLog { get; set; }

    public string? UserId { get; set; }

    public string? PlannerId { get; set; }

    public string? ItemNumberFrom { get; set; }

    public string? ItemNumberUpto { get; set; }

    public DateTime? CalculationStarted { get; set; }

    public DateTime? CalculationEnded { get; set; }

    public string? Status { get; set; }
}
