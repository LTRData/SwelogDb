using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductionAttest
{
    public int EmploymentNo { get; set; }

    public int YearNo { get; set; }

    public int WeekNo { get; set; }

    public string? AttestedBy { get; set; }

    public DateTime? AttestDate { get; set; }
}
