using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class UserrepMain
{
    public string ReportName { get; set; } = null!;

    public string? ReportXml { get; set; }
}
