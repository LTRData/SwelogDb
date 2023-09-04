using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwFactResourceTime
{
    public string TrnType { get; set; } = null!;

    public DateTime? TrnDate { get; set; }

    public DateTime? StartDateTime { get; set; }

    public DateTime ReportDateTime { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }

    public decimal? ResourceTime { get; set; }

    public decimal? SetupTime { get; set; }

    public decimal? QtyProduced { get; set; }

    public decimal? QtyNotApproved { get; set; }

    public string? InterruptCode { get; set; }

    public string? DirectActivityType { get; set; }

    public string? DirectActivityNo { get; set; }

    public string? ActivityNo { get; set; }

    public short? Year { get; set; }

    public short? Week { get; set; }

    public short? Day { get; set; }

    public short? MonthNo { get; set; }

    public decimal? PlannedTime { get; set; }

    public string? ResourceDescription { get; set; }
}
