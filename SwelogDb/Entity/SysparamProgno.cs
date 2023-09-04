using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SysparamProgno
{
    public string CompanyId { get; set; } = null!;

    public string? CurrencyYear1 { get; set; }

    public string? AlloyYear1 { get; set; }

    public string? ScrapYear1 { get; set; }

    public string? CurrencyYear2 { get; set; }

    public string? AlloyYear2 { get; set; }

    public string? ScrapYear2 { get; set; }

    public string? CurrencyYear3 { get; set; }

    public string? AlloyYear3 { get; set; }

    public string? ScrapYear3 { get; set; }

    public string? AuditStamp { get; set; }

    public bool? FollowupQ1 { get; set; }

    public bool? FollowupQ2 { get; set; }

    public bool? FollowupQ3 { get; set; }

    public bool? FollowupQ4 { get; set; }

    public bool? UseNextYearForecastForBudget { get; set; }
}
