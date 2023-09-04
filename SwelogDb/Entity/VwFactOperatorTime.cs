using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwFactOperatorTime
{
    public string TrnType { get; set; } = null!;

    public int EmploymentNo { get; set; }

    public DateTime? ShiftDate { get; set; }

    public DateTime? FromDateTime { get; set; }

    public DateTime? UptoDateTime { get; set; }

    public string? ResourceNumber { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }

    public decimal? OperatorTime { get; set; }

    public decimal? SetupTime { get; set; }

    public decimal? QtyProduced { get; set; }

    public decimal? QtyNotApproved { get; set; }

    public string? InterruptCode { get; set; }

    public string? DirectActivityType { get; set; }

    public string? DirectActivityNo { get; set; }

    public string? ActivityNo { get; set; }

    public short? Year { get; set; }

    public short? WeekNo { get; set; }

    public short? DayOfWeek { get; set; }

    public short? MonthNo { get; set; }

    public decimal? Minutes { get; set; }

    public decimal? PlannedTime { get; set; }

    public string? PersonCatg { get; set; }

    public string? EmployeeName { get; set; }
}
