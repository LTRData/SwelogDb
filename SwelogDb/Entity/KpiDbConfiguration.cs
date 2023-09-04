using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class KpiDbConfiguration
{
    public int ConfigId { get; set; }

    public string? ConfigDescription { get; set; }

    public int? Gauge1Type { get; set; }

    public int? Gauge2Type { get; set; }

    public int? Gauge3Type { get; set; }

    public int? Chart1Type { get; set; }

    public int? Chart2Type { get; set; }

    public int? Chart3Type { get; set; }

    public int? Chart4Type { get; set; }

    public string? AuditStamp { get; set; }

    public int? Chart1Id { get; set; }

    public int? Chart2Id { get; set; }

    public int? Chart3Id { get; set; }

    public int? Chart4Id { get; set; }
}
