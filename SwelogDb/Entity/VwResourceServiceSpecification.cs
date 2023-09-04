using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwResourceServiceSpecification
{
    public string? ResourceOnService { get; set; }

    public string MfgOrderNumber { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public short OperationNumber { get; set; }

    public string? ResourceNumber { get; set; }

    public short Year { get; set; }

    public short Week { get; set; }

    public short Day { get; set; }

    public decimal? ResourceLoadInHours { get; set; }

    public decimal? ResourceSetupTime { get; set; }

    public decimal? OperatorLoadInHours { get; set; }

    public decimal? Manning { get; set; }
}
