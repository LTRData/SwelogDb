using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PlTemplateDtlKey
{
    public int RecNo { get; set; }

    public int LineNo { get; set; }

    public string? SubGroupCol { get; set; }

    public string? WhichKey { get; set; }

    public string? KeyNoFrom { get; set; }

    public string? KeyNoTo { get; set; }

    public string? AccountDetails { get; set; }

    public string? AuditStamp { get; set; }

    public string? ExcludeValues { get; set; }

    public string? StartAccount { get; set; }

    public string? FinishAccount { get; set; }

    public string? Text { get; set; }

    public string? ExclusiveAccounts { get; set; }

    public string? InclusiveAccounts { get; set; }

    public virtual PlTemplateHdrKey RecNoNavigation { get; set; } = null!;
}
