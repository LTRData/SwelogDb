using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MpcResourceReport
{
    public decimal KeyNo { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public string? ActivityNo { get; set; }

    public string ActivityType { get; set; } = null!;

    public string ReportType { get; set; } = null!;

    public DateTime StartDateTime { get; set; }

    public DateTime EndDateTime { get; set; }

    public int StartReportBy { get; set; }

    public int EndReportBy { get; set; }

    public decimal QtyProduced { get; set; }

    public decimal QtyNotApproved { get; set; }

    public string WithoutOperator { get; set; } = null!;

    public decimal? SetupTime { get; set; }

    public int? NoOfSetup { get; set; }

    public decimal? ResourceTime { get; set; }

    public decimal? InterruptTime { get; set; }

    public string? ProductionGroupId { get; set; }

    public DateTime? GrpValidFrom { get; set; }

    public DateTime? GrpValidUpto { get; set; }

    public string? WageTransOption { get; set; }

    public string? FinalDelivery { get; set; }
}
