using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PfmeaRelation
{
    public int IdPfmeaRelation { get; set; }

    public string? RecTypeSeeker { get; set; }

    public int? BranchIdSeeker { get; set; }

    public string? RecTypeSought { get; set; }

    public int? BranchIdSought { get; set; }
}
