using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Attestation
{
    public int EmploymentNumber { get; set; }

    public DateTime AttestationDate { get; set; }

    public string? TypeOfAttestation { get; set; }

    public DateTime? TimeFrom { get; set; }

    public DateTime? TimeUntil { get; set; }

    public string? AbsentCode { get; set; }

    public string? Description { get; set; }

    public decimal? Author { get; set; }

    public string? AuditStamp { get; set; }
}
