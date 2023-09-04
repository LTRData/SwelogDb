using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EdDoorDecoration
{
    public int DecorId { get; set; }

    public string? ModelNumber { get; set; }

    public string? DecorType { get; set; }

    public int? DecorBreadth { get; set; }

    public int? DecorHeight { get; set; }

    public int? DecorCount { get; set; }

    public string? AuditStamp { get; set; }

    public short? DecorThickness { get; set; }

    public string? BreadthFormula { get; set; }

    public string? HeightFormula { get; set; }

    public string? DecorShape { get; set; }
}
