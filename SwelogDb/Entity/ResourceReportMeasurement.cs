using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ResourceReportMeasurement
{
    public int IdResourceReportMeasurement { get; set; }

    public string? ResourceNumber { get; set; }

    public DateTime? ReportDateTime { get; set; }

    public string? ActivityNo { get; set; }

    public int? SequenceNo { get; set; }

    public int? ReportedBy { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }

    public decimal? MoisturePercent { get; set; }

    public decimal? Temperature { get; set; }

    public decimal? MarkupQuantity { get; set; }
}
