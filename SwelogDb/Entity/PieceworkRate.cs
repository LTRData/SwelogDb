using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PieceworkRate
{
    public int PieceworkNumber { get; set; }

    public DateTime ValidFrom { get; set; }

    public int Percentage { get; set; }

    public decimal Rate { get; set; }

    public virtual PieceworkMaster PieceworkNumberNavigation { get; set; } = null!;
}
