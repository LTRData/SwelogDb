using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AbsenceCode
{
    public string AbsenceCode1 { get; set; } = null!;

    public string PersonCatg { get; set; } = null!;

    public DateTime AbsenceCodeValidFrom { get; set; }

    public DateTime? AbsenceCodeValidUntil { get; set; }

    public string? AbsenceCodeDescription { get; set; }

    public string? WageTransactionFlag { get; set; }

    public string? WageType { get; set; }

    public short? RoundOffInMinutes { get; set; }

    public string? ReportingUnit { get; set; }

    public string? CalendarWorkingDays { get; set; }

    public string? WageTransactionSummaryFlag { get; set; }

    public string? ExtraCompensationFlag { get; set; }

    public string? LeaveAsPresentFlag { get; set; }

    public string? SignalListPrintFlag { get; set; }

    public short? AutoAttestLimitInMinutes { get; set; }

    public string? AuditStamp { get; set; }

    public string? WorkTimeReduction { get; set; }

    public string? CompFlag { get; set; }

    public byte? KarensDays { get; set; }

    public string? KarensWageType { get; set; }

    public string? AbsenceExtraCompensationFlag { get; set; }

    public string? WorkTimeReductionFlag { get; set; }
}
