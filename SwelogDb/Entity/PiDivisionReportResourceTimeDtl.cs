using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PiDivisionReportResourceTimeDtl
{
    public string ActivityNo { get; set; } = null!;

    public string ResourceNumber { get; set; } = null!;

    public int SequenceNo { get; set; }

    public DateTime ActualStart { get; set; }

    public DateTime StartDateTime { get; set; }

    public DateTime EndDateTime { get; set; }

    public string? EventId { get; set; }

    public decimal? EventTime { get; set; }

    public DateTime? MpcStartDate { get; set; }

    public DateTime? MpcEndDate { get; set; }

    public string? InterruptCode { get; set; }
}
