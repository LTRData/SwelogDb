using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MpcResourceEvent
{
    public decimal KeyNo { get; set; }

    public decimal EventKeyNo { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public string? ActivityNo { get; set; }

    public string ActivityType { get; set; } = null!;

    public DateTime StartDateTime { get; set; }

    public DateTime EndDateTime { get; set; }

    public string EventId { get; set; } = null!;

    public string? InterruptCode { get; set; }

    public decimal? EventTime { get; set; }

    public string? ProductionGroupId { get; set; }

    public string? TimeShareCode { get; set; }

    public short? PercentShare { get; set; }

    public string? WithoutOperator { get; set; }

    public DateTime? GrpValidFrom { get; set; }

    public string? WageTransOption { get; set; }

    public DateTime? GrpValidUpto { get; set; }

    public decimal? OriginalEventKeyNo { get; set; }

    public int? ReportedBy { get; set; }
}
