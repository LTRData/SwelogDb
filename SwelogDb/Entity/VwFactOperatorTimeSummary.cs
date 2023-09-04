using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwFactOperatorTimeSummary
{
    public int EmploymentNo { get; set; }

    public DateTime? ShiftDate { get; set; }

    public decimal? AttendanceTime { get; set; }

    public decimal? DirectTime { get; set; }

    public decimal? IndirectTime { get; set; }

    public decimal? PlannedTime { get; set; }

    public short? Year { get; set; }

    public short? WeekNo { get; set; }

    public short? DayOfWeek { get; set; }

    public short? MonthNo { get; set; }
}
