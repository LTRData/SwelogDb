using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgProductionCase
{
    public string MfgProductionCase1 { get; set; } = null!;

    public int? MfgProductionCaseDescriptionText { get; set; }

    public string? ActiveYn { get; set; }
}
