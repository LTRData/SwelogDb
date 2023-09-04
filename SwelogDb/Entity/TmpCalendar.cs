using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpCalendar
{
    public int? ProcessId { get; set; }

    public int? CalRow { get; set; }

    public int? EmploymentNo { get; set; }

    public DateTime? ShiftDate { get; set; }

    public string? AttendanceIndicator { get; set; }

    public string? OvertimeAbsenceCode { get; set; }

    public string? AttestFlag { get; set; }

    public int? AttestedBy { get; set; }

    public DateTime? FromTimeFlexiPlus { get; set; }

    public DateTime? FromTimeFlexiMinus { get; set; }

    public DateTime? UptoTimeFlexiPlus { get; set; }

    public DateTime? UptoTimeFlexiMinus { get; set; }

    public DateTime? FromDateTime { get; set; }

    public string? FromTimeIndicator { get; set; }

    public DateTime? UptoDateTime { get; set; }

    public string? UptoTimeIndicator { get; set; }

    public string? BreakReportOption { get; set; }

    public string? BreakNormalFlag { get; set; }

    public int? BreakMinimum { get; set; }
}
