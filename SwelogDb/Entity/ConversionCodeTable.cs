using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ConversionCodeTable
{
    public string TableIndicator { get; set; } = null!;

    public string DataInFile { get; set; } = null!;

    public string? DataToUse { get; set; }

    public string? AuditStamp { get; set; }
}
