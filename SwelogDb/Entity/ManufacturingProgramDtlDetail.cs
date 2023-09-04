using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ManufacturingProgramDtlDetail
{
    public string MfgProgramId { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public short SequenceNumber { get; set; }

    public DateTime? MfgProgItemDueDate { get; set; }

    public decimal? MfgProgramQuantity { get; set; }

    public decimal? PlannedQuantity { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ManufacturingProgramDtl ManufacturingProgramDtl { get; set; } = null!;
}
