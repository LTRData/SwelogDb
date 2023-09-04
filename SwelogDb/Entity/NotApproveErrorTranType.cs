using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NotApproveErrorTranType
{
    public int TranType { get; set; }

    public string? TranDesc { get; set; }

    public string? ReworkFlag { get; set; }

    public int? Color { get; set; }
}
