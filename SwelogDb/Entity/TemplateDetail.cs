using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TemplateDetail
{
    public string CompanyNo { get; set; } = null!;

    public decimal TemplateNo { get; set; }

    public decimal LineNo { get; set; }

    public decimal? SerialNo { get; set; }

    public string? ControlCode { get; set; }

    public string? StartAccount { get; set; }

    public string? FinishAccount { get; set; }

    public string? Text { get; set; }

    public string? AuditStamp { get; set; }

    public string? Line { get; set; }

    public string? Sort { get; set; }

    public string? SmallLine { get; set; }

    public string? WhichKey { get; set; }

    public string? KeyNoFrom { get; set; }

    public string? KeyNoTo { get; set; }

    public string? ExcludeValues { get; set; }

    public virtual TemplateHeader TemplateHeader { get; set; } = null!;
}
