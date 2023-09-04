using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReportCedocCommand
{
    public string ReportId { get; set; } = null!;

    public string CommandCategory { get; set; } = null!;

    public string Command { get; set; } = null!;
}
