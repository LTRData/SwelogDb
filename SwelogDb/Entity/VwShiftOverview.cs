using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwShiftOverview
{
    public int EmploymentNo { get; set; }

    public DateTime ShiftDate { get; set; }

    public DateTime? StartDateTime { get; set; }

    public DateTime? EndDateTime { get; set; }

    public decimal? AttendanceTime { get; set; }

    public string? TimeCategory { get; set; }

    public string? PersonCatg { get; set; }

    public string? TimeModel { get; set; }

    public double? WorkingHours { get; set; }

    public int? YearNo { get; set; }

    public int? MonthNo { get; set; }
}
