using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu168Riskfra
{
    public int SerialNumber { get; set; }

    public string? RiskfrasKod { get; set; }

    public string? RiskfrasBeskrivning { get; set; }

    public string? Signalord { get; set; }

    public string? Piktogram { get; set; }
}
