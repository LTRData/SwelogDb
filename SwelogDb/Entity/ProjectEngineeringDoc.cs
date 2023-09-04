using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProjectEngineeringDoc
{
    public string ProjectEngineeringType { get; set; } = null!;

    public int ProjectEngineeringOperation { get; set; }

    public string? ProjectEngineeringOperationDesc { get; set; }

    public int? ProjectEngineeringOperationDescTxtid { get; set; }

    public string? ProjectEngineeringOperationDescFlag { get; set; }

    public string DocType { get; set; } = null!;

    public string? ProjectYn { get; set; }

    public string? PurchCompYn { get; set; }

    public string? MfgCompYn { get; set; }

    public string? PurchToolYn { get; set; }

    public string? MfgToolYn { get; set; }

    public string? AuditStamp { get; set; }
}
