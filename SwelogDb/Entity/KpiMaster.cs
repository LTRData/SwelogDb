using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class KpiMaster
{
    public byte KpiId { get; set; }

    public string? KpiDescription { get; set; }

    public string? KpiType { get; set; }

    public string? KpiKeys { get; set; }

    public string? KpiValues { get; set; }

    public string? UserKeys { get; set; }

    public string? UserLabels { get; set; }

    public int? MaxValue { get; set; }

    public int? DivisionFactor { get; set; }

    public int? ChartType { get; set; }

    public bool? ActiveFlag { get; set; }
}
