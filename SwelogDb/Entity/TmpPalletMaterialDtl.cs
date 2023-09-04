using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpPalletMaterialDtl
{
    public int? ProcessId { get; set; }

    public string? MaterialItemNumber { get; set; }

    public string? MaterialPalletNo { get; set; }

    public string? MaterialControlId { get; set; }
}
