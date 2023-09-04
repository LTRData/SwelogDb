using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class InOutRecord
{
    public int EmploymentNo { get; set; }

    public DateTime KeyDateTime { get; set; }

    public string? InOutIndicator { get; set; }

    public string? CurrentAttendanceInd { get; set; }

    public string? CompensationCode { get; set; }

    public string? CurrentAbsenceInd { get; set; }

    public string? CurrentAbsenceCode { get; set; }

    public string? NextPrevAbsenceInd { get; set; }

    public string? NextPrevAbsenceCode { get; set; }

    public string? RealTimeIndicator { get; set; }

    public string? RecordStatus { get; set; }

    public int? TerminalNo { get; set; }

    public int? UpdatedBy { get; set; }

    public string? AuditStamp { get; set; }

    public string? WorkOnFreedayOption { get; set; }
}
