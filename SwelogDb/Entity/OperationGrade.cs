using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OperationGrade
{
    public string SupplierId { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public short OperationNumber { get; set; }

    public string YearMonth { get; set; } = null!;

    public decimal? MonthGrade { get; set; }

    public decimal? YearGrade { get; set; }

    public string? AuditStamp { get; set; }
}
