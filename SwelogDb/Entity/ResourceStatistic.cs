using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ResourceStatistic
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public int OperationNumber { get; set; }

    public DateTime ReportDatetime { get; set; }

    public decimal ResourceSetupTime { get; set; }

    public decimal ResourceTime { get; set; }

    public decimal? QuantityProduced { get; set; }

    public decimal SerialNumber { get; set; }

    public string ResourceNo { get; set; } = null!;

    public string? ResourceDescription { get; set; }

    public decimal? AverageHourlyEarning { get; set; }

    public int MinSerialNumber { get; set; }

    public decimal? PlanResSetupTime { get; set; }

    public decimal? PlanResTime { get; set; }

    public string? PieceWorkTypeCode { get; set; }

    public decimal? OperationSetupCost { get; set; }

    public decimal? TimeRateFixedPart { get; set; }

    public string? ActivityDescription { get; set; }

    public decimal? ResourceIndirectTime { get; set; }

    public string? ProductionGroupId { get; set; }

    public string? CostCentre { get; set; }

    public string ActualResourceNumber { get; set; } = null!;

    public string? ReportCompleteIndicator { get; set; }

    public int? ReportedBy { get; set; }
}
