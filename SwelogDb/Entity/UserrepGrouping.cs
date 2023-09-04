using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class UserrepGrouping
{
    public string GroupName { get; set; } = null!;

    public string? GroupDescription { get; set; }

    public string? SampleReportName { get; set; }

    public string? StandardTableList { get; set; }
}
