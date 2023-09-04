using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OperatorWageHeader
{
    public int EmployeeNumber { get; set; }

    public string WorkplaceId { get; set; } = null!;

    public string ActivityInd { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public string? ResourceNumber { get; set; }

    public DateTime? ValidUpto { get; set; }

    public decimal OperatorTime { get; set; }

    public decimal TimeWorkRate { get; set; }

    public decimal? TimeRateFixedPart { get; set; }

    public string? WageType { get; set; }

    public decimal HighAlarm { get; set; }

    public decimal LowAlarm { get; set; }

    public string? PieceWorkTypeCode { get; set; }

    public string? WageTransOption { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? AuditStamp { get; set; }
}
