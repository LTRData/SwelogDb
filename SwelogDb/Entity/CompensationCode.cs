using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CompensationCode
{
    public string CompensationCode1 { get; set; } = null!;

    public string PersonCatg { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidUntil { get; set; }

    public string? CompCodeDescription { get; set; }

    public short? RoundOffInMinutes { get; set; }

    public short? SmallestCompTime { get; set; }

    public string? RegularWorkCompleteFlag { get; set; }

    public string? OtCompAsRegularWorkFlag { get; set; }

    public string? WageTransactionSummaryFlag { get; set; }

    public string? ExtraCompensationFlag { get; set; }

    public string? SignalListPrintFlag { get; set; }

    public short? AutoAttestLimitInMinutes { get; set; }

    public string? AuditStamp { get; set; }

    public string? ExcludeInMpcSelectionFlag { get; set; }

    public string? CompFlag { get; set; }

    public short? LongestCompTime { get; set; }

    public string? WageTransactionFlag { get; set; }
}
