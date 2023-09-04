using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ManufacturingProgramDtl
{
    public string MfgProgramId { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public DateTime? MfgProgramFromPeriod { get; set; }

    public DateTime? MfgProgramToPeriod { get; set; }

    public string? UnitOfMeasure { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Item ItemNumberNavigation { get; set; } = null!;

    public virtual ICollection<ManufacturingProgramDtlDetail> ManufacturingProgramDtlDetails { get; } = new List<ManufacturingProgramDtlDetail>();

    public virtual ManufacturingProgramHdr MfgProgram { get; set; } = null!;

    public virtual UnitOfMeasure? UnitOfMeasureNavigation { get; set; }
}
