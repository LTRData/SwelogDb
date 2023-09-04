using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OperatorStatistic
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public int OperationNumber { get; set; }

    public int EmployeeNumber { get; set; }

    public DateTime ReportDatetime { get; set; }

    public decimal OperatorSetupTime { get; set; }

    public decimal OperatorTime { get; set; }

    public decimal? QuantityProduced { get; set; }

    public decimal SerialNumber { get; set; }

    public string? PieceWorkTypeCode { get; set; }

    public decimal? PieceWorkRate { get; set; }

    public string ResourceNo { get; set; } = null!;

    public string? ResourceDescription { get; set; }

    public decimal? AverageHourlyEarning { get; set; }

    public int MinSerialNumber { get; set; }

    public decimal? PlanOpSetupTime { get; set; }

    public decimal? PlanOpTime { get; set; }

    public decimal? OperationSetupCost { get; set; }

    public decimal? TimeRateFixedPart { get; set; }

    public string? ActivityDescription { get; set; }

    public decimal? OperatorIndirectTime { get; set; }

    public decimal? OperatorIndirectWork { get; set; }
}
