using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PieceworkMaster
{
    public int PieceworkNumber { get; set; }

    public string PieceworkDescription { get; set; } = null!;

    public virtual ICollection<PieceworkRate> PieceworkRates { get; } = new List<PieceworkRate>();
}
