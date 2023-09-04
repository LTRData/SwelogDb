using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TimeCatgHdr
{
    public string TimeCatg { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidUntil { get; set; }

    public string? CategoryDesc { get; set; }

    public int? StartWeek { get; set; }

    public short? OvertimeMarginIn { get; set; }

    public short? OvertimeMarginOut { get; set; }

    public string? ShiftCompensationOption { get; set; }

    public string? WorkTimeSavingFlag { get; set; }

    public string? FlexiTimeBalancingFlag { get; set; }

    public string? FlexiTimeBalancePeriod { get; set; }

    public string? AuditStamp { get; set; }

    public string? ShiftCompWageType { get; set; }

    public string? WorkTimeWageType { get; set; }

    public decimal? MinFlexiLimit { get; set; }

    public decimal? MaxFlexiLimit { get; set; }

    public decimal? AvgWeekWorkHours { get; set; }

    public decimal? WorkTimeReduceMinutes { get; set; }

    public string? WorkTimeIncludeFlexi { get; set; }

    public bool? CompBankFlag { get; set; }

    public int? CompBankLimit { get; set; }

    public int? StopTimeReduceMinutes { get; set; }

    public string? StopTimeWageType { get; set; }
}
