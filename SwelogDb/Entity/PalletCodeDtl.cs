using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PalletCodeDtl
{
    public string PalletCode { get; set; } = null!;

    public string LabelCode { get; set; } = null!;

    public byte? NoOfLabels { get; set; }

    public string? AuditStamp { get; set; }
}
