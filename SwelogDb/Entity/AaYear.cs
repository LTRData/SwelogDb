using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AaYear
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string? Closed { get; set; }
}
