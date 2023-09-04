using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StuctureGroupParameter
{
    public string TopitemNumber { get; set; } = null!;

    public string GroupCode { get; set; } = null!;

    public string TopitemParameterCode { get; set; } = null!;

    public int? OrderIx { get; set; }

    public string? AuditStamp { get; set; }
}
