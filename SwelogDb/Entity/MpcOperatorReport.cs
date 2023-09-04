using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MpcOperatorReport
{
    public decimal KeyNo { get; set; }

    public decimal EventKeyNo { get; set; }

    public string ActivityInd { get; set; } = null!;

    public string ResourceNumber { get; set; } = null!;

    public string ActivityNo { get; set; } = null!;

    public string ActivityType { get; set; } = null!;

    public int EmployeeNumber { get; set; }

    public DateTime StartDateTime { get; set; }

    public DateTime EndDateTime { get; set; }

    public decimal Seconds { get; set; }

    public decimal PercentShare { get; set; }

    public string EventId { get; set; } = null!;

    public string? InterruptCode { get; set; }

    public string? ProductionGroupId { get; set; }

    public string? TimeShareCode { get; set; }

    public decimal? NormalTime { get; set; }

    public decimal? OverTime { get; set; }

    public DateTime? GrpValidFrom { get; set; }

    public string? WageTransOption { get; set; }

    public DateTime? GrpValidUpto { get; set; }

    public decimal? OriginalEventKeyNo { get; set; }

    public DateTime? ShiftDate { get; set; }
}
