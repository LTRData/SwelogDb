using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ResourceCapacity
{
    public int EmploymentNo { get; set; }

    public DateTime TrnDate { get; set; }

    public short Year { get; set; }

    public short Week { get; set; }

    public short Day { get; set; }

    public decimal OperatorCapacity { get; set; }

    public decimal ResourceCapacity1 { get; set; }

    public string? AuditStamp { get; set; }

    public string? ActivityInd { get; set; }

    public string? WorkplaceId { get; set; }

    public short? CalYearNo { get; set; }

    public short? CalMonthNo { get; set; }

    public int? FiscalYearNo { get; set; }

    public int? FiscalMonthNo { get; set; }
}
