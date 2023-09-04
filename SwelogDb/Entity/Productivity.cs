using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Productivity
{
    public int EmploymentNo { get; set; }

    public short Year { get; set; }

    public short Month { get; set; }

    public short Week { get; set; }

    public DateTime TrnDate { get; set; }

    public string? CostCentre { get; set; }

    public string? ShiftCode { get; set; }

    public decimal? Capacity { get; set; }

    public decimal? AttendanceTime { get; set; }

    public decimal? DirectTime { get; set; }

    public decimal? PlannedTime { get; set; }

    public decimal? IndirectTime { get; set; }

    public string? Yearweek { get; set; }

    public DateTime? CreateTimestamp { get; set; }

    public decimal? IndirectTimeForBonus { get; set; }

    public decimal? Quantity { get; set; }
}
