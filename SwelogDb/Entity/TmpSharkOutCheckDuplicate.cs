using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpSharkOutCheckDuplicate
{
    public int RecNo { get; set; }

    public string? TxtValue { get; set; }

    public string? DuplicateRec { get; set; }
}
