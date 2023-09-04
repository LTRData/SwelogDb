using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TransFileWageConnect
{
    public string WageCategory { get; set; } = null!;

    public string WagePeriod { get; set; } = null!;

    public int RecordSrl { get; set; }

    public int? EmploymentNumber { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? WageType { get; set; }

    public string? WageSpec { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Price { get; set; }

    public int? ChangedBy { get; set; }

    public string? AuditStamp { get; set; }

    public string? WageTypeSum { get; set; }

    public string? AbsenceFlag { get; set; }

    public string? TimeType { get; set; }

    public int? AckordUnit { get; set; }

    public int? AckordProducedQty { get; set; }

    public int? AckordPrice { get; set; }

    public int? AckordSetupPrice { get; set; }

    public string? CostCenter { get; set; }

    public string? ReportingUnit { get; set; }

    public string? CalendarWorkingDays { get; set; }

    public string? AbsenceCode { get; set; }
}
