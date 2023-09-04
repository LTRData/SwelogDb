using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ElementTable
{
    public int ElementNo { get; set; }

    public string ElementName { get; set; } = null!;

    public string ElementType { get; set; } = null!;

    public string? ElementDataType { get; set; }

    public int? ElementWidth { get; set; }

    public int? ElementDecimal { get; set; }

    public string? ElementNullAllowedIndicator { get; set; }

    public string? ElementDefaultValue { get; set; }

    public string? ElementDescription { get; set; }

    public string? AuditStamp { get; set; }
}
