using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PiDivisionReportResourceTime
{
    public string ActivityNo { get; set; } = null!;

    public string ResourceNumber { get; set; } = null!;

    public int SequenceNo { get; set; }

    public string ProductionGroupId { get; set; } = null!;

    public DateTime StartDateTime { get; set; }

    public DateTime EndDateTime { get; set; }

    public DateTime ActualStart { get; set; }

    public decimal ResourceTime { get; set; }

    public int StartedBy { get; set; }

    public int ReportedBy { get; set; }
}
