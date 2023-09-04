using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PiMpcSelectionLog
{
    public int LogId { get; set; }

    public DateTime? LogDateTime { get; set; }

    public string? LogMessage { get; set; }

    public DateTime MpcStartDate { get; set; }

    public DateTime MpcEndDate { get; set; }
}
