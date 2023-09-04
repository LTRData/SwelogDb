using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TempBlockDetail
{
    public string CompanyNo { get; set; } = null!;

    public decimal TemplateNo { get; set; }

    public string AccNoFrom { get; set; } = null!;

    public string AccNoTo { get; set; } = null!;

    public string? HeaderText { get; set; }

    public string? FooterText { get; set; }

    public string? Sort { get; set; }

    public string? Line { get; set; }

    public decimal RecNo { get; set; }

    public decimal? Niva { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? SeriesNo { get; set; }
}
