using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwTrIndividualCalendar
{
    public int EmploymentNo { get; set; }

    public DateTime? ShiftDate { get; set; }

    public DateTime FromDateTime { get; set; }

    public DateTime? UptoDateTime { get; set; }

    public int? MinuteCount { get; set; }

    public string? AttendanceType { get; set; }
}
