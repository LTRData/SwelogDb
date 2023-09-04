using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PlTemplateDtlDtl
{
    public int RecId { get; set; }

    public int? RecNo { get; set; }

    public int? LineNo { get; set; }

    public string? AccountNo { get; set; }

    public string? WhichKey { get; set; }

    public string? KeyNo { get; set; }

    public string? ActionWhat { get; set; }

    public string? ActionWho { get; set; }

    public DateTime? ActionWhen { get; set; }

    public string? ActionSign { get; set; }

    public DateTime? ActionCompletedDate { get; set; }

    public string? AuditStamp { get; set; }

    public string? Finished { get; set; }

    public DateTime? PlannedFinishedDate { get; set; }

    public DateTime? StartDate { get; set; }
}
