using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TemplateHeader
{
    public string CompanyNo { get; set; } = null!;

    public decimal TemplateNo { get; set; }

    public string? TemplateName { get; set; }

    public string? ReportTitle { get; set; }

    public decimal? ColumnTemplate { get; set; }

    public decimal? RoundOffMethod { get; set; }

    public decimal? ListOption { get; set; }

    public decimal? SignChange { get; set; }

    public string? AuditStamp { get; set; }

    public short? Col1 { get; set; }

    public short? Col2 { get; set; }

    public short? Col3 { get; set; }

    public short? Col4 { get; set; }

    public short? Col5 { get; set; }

    public short? Col6 { get; set; }

    public short? PaperOrientation { get; set; }

    public string? OnlyAccWithBal { get; set; }

    public virtual ICollection<TemplateDetail> TemplateDetails { get; } = new List<TemplateDetail>();
}
