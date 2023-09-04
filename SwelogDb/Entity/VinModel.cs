using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VinModel
{
    public string ModelId { get; set; } = null!;

    public string? ModelDesc { get; set; }

    public int? StartingSerialNumber { get; set; }

    public int? LastSerialUsed { get; set; }

    public int? Weight { get; set; }

    public int? ModelYear { get; set; }

    public string? EuTypeNumber { get; set; }

    public int? AxleLoad1 { get; set; }

    public int? AxleLoad2 { get; set; }

    public int? AxleLoad0 { get; set; }

    public int? AxleLoad3 { get; set; }
}
