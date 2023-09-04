using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpBadCustOrderLine
{
    public int RecNo { get; set; }

    public string? OrderNumber { get; set; }

    public int? OrderLineNumber { get; set; }
}
