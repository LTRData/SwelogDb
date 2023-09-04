using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductivityPerEmployee
{
    public short Year { get; set; }

    public short Week { get; set; }

    public short Month { get; set; }

    public int EmploymentNo { get; set; }

    public decimal? Productivity { get; set; }

    public decimal? Efficiency { get; set; }

    public decimal? UsageDegree { get; set; }

    public DateTime? CreateTimestamp { get; set; }

    public decimal? Quantity { get; set; }
}
