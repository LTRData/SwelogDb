using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EmployeeWageDetail
{
    public int EmploymentNumber { get; set; }

    public DateTime WageValidFrom { get; set; }

    public string? Remarks { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? HourlyWage { get; set; }

    public decimal? WageFixedPart { get; set; }

    public string? TimeWage { get; set; }
}
