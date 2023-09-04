using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemGrade
{
    public string SupplierId { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string YearMonth { get; set; } = null!;

    public decimal? MonthGrade { get; set; }

    public decimal? YearGrade { get; set; }

    public string? AuditStamp { get; set; }
}
