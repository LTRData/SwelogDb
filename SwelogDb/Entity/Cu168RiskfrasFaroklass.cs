using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu168RiskfrasFaroklass
{
    public int SerialNumber { get; set; }

    public string RiskfrasKod { get; set; } = null!;

    public string Faroklass { get; set; } = null!;
}
