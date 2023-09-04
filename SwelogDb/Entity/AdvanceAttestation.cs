using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AdvanceAttestation
{
    public int EmploymentNo { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? AttestFor { get; set; }

    public string? Intermittent { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? FromTime { get; set; }

    public DateTime? UptoDate { get; set; }

    public DateTime? UptoTime { get; set; }

    public string? AttestCode { get; set; }

    public int? AttestedBy { get; set; }

    public string? AuditStamp { get; set; }

    public int RowId { get; set; }
}
