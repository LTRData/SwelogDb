using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EdDoorBodyParm
{
    public bool HdfWoodType { get; set; }

    public bool StandardClass { get; set; }

    public bool StandardSize { get; set; }

    public int? BodyLeadTime { get; set; }

    public string? AuditStamp { get; set; }
}
