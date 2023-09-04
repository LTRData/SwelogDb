using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProjectEngineeringType
{
    public string ProjectEngineeringType1 { get; set; } = null!;

    public string? ProjectEngineeringTypeDesc { get; set; }

    public int? ProjectEngineeringTypeDescTxtid { get; set; }

    public string? ProjectEngineeringTypeDescFlag { get; set; }

    public string? AuditStamp { get; set; }
}
