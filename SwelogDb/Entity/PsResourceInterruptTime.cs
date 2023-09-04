using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PsResourceInterruptTime
{
    public int IdPsResourceInterruptTime { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public string InterruptCode { get; set; } = null!;

    public DateTime FromDateTime { get; set; }

    public DateTime UptoDateTime { get; set; }

    public string? ActivityNo { get; set; }

    public string ActivityType { get; set; } = null!;

    public int SequenceNo { get; set; }

    public int ReportedBy { get; set; }

    public decimal ResourceTime { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }

    public DateTime? MpcStartDate { get; set; }

    public DateTime? MpcEndDate { get; set; }

    public string? AuditStamp { get; set; }
}
