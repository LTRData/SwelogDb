using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ControlText
{
    public string ControlTextCode { get; set; } = null!;

    public string? ControlDescription { get; set; }

    public string? AuditStamp { get; set; }

    public int? ControlDescriptionTxtid { get; set; }

    public string? ControlDescriptionFlag { get; set; }

    public virtual ICollection<ManufacturingInspectionHdr> ManufacturingInspectionHdrs { get; } = new List<ManufacturingInspectionHdr>();

    public virtual ICollection<MfgMfgInspectionHdr> MfgMfgInspectionHdrs { get; } = new List<MfgMfgInspectionHdr>();
}
