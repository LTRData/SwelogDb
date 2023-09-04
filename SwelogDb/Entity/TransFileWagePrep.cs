using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TransFileWagePrep
{
    public string WageCategory { get; set; } = null!;

    public string WagePeriod { get; set; } = null!;

    public int RecordSrl { get; set; }

    public int? EmploymentNumber { get; set; }

    public DateTime? ShiftDate { get; set; }

    public DateTime? FromDateTime { get; set; }

    public DateTime? UptoDateTime { get; set; }

    public string? AttendanceIndicator { get; set; }

    public string? OvertimeAbsenceCode { get; set; }

    public string? WageType { get; set; }

    public string? AttestFlag { get; set; }

    public int? AttestedBy { get; set; }

    public string? AuditStamp { get; set; }

    public string? ErrorId { get; set; }

    public string? ErrorDescr { get; set; }

    public string? SignalListPrintFlag { get; set; }

    public string? TotalAttendanceFlag { get; set; }

    public string? TransactionSummaryFlag { get; set; }

    public string? ReportingUnit { get; set; }

    public string? CalendarWorkingDays { get; set; }

    public string? WorkTimeReduction { get; set; }

    public short? SmallestCompTime { get; set; }

    public short? LongestCompTime { get; set; }
}
