using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgOrderPicklistDetail
{
    public int PicklistNumber { get; set; }

    public int OperationNumber { get; set; }

    public string? MfgOrderLine { get; set; }
}
