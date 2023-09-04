using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpAlloySurcharge
{
    public string ParentItem { get; set; } = null!;

    public decimal? AlloySurchargeFc { get; set; }

    public decimal? AlloySurchargeBc { get; set; }
}
