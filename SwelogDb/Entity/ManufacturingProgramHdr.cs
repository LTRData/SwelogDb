using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ManufacturingProgramHdr
{
    public string MfgProgramId { get; set; } = null!;

    public string? MfgProgramName { get; set; }

    public string? PlannerId { get; set; }

    public string? ProductFamilyCode { get; set; }

    public DateTime? MfgProgramFromPeriod { get; set; }

    public DateTime? MfgProgramToPeriod { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ManufacturingProgramDtl> ManufacturingProgramDtls { get; } = new List<ManufacturingProgramDtl>();
}
