using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmPriority
{
    public short PriorityCode { get; set; }

    public string? PriorityDescription { get; set; }
}
