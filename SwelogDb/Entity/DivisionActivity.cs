using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DivisionActivity
{
    public string ActivityNo { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidUpto { get; set; }

    public string? DivisionDescription { get; set; }

    public string? DivisionRule { get; set; }

    public string? PayIndirectActivity { get; set; }

    public string? WageTransOption { get; set; }

    public string? PieceWorkTypeCode { get; set; }

    public string? DirectWageType { get; set; }

    public string? AuditStamp { get; set; }

    public string? ShowReportsSinceActivityStart { get; set; }
}
