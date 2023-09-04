using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PiOfflineDivisionReport
{
    public int ReportId { get; set; }

    public int? EmploymentNo { get; set; }

    public DateTime? ReportDateTime { get; set; }

    public DateTime? StartDateTime { get; set; }

    public DateTime? EndDateTime { get; set; }

    public decimal? PreviousUndividedTime { get; set; }

    public decimal? AttendanceTime { get; set; }

    public string? AuditStamp { get; set; }
}
