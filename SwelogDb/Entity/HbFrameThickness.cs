using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class HbFrameThickness
{
    public short Thickness { get; set; }

    public string Prefix { get; set; } = null!;

    public short InnerFrameThickness { get; set; }

    public string? AuditStamp { get; set; }
}
