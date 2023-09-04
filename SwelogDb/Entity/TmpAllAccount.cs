using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpAllAccount
{
    public int RecId { get; set; }

    public string? CompanyNo { get; set; }

    public int? YearNo { get; set; }

    public int? RecNo { get; set; }

    public string? GroupCol { get; set; }

    public int? LineNo { get; set; }

    public string? SubGroupCol { get; set; }

    public string? AccountNo { get; set; }

    public string? AccountDescription { get; set; }

    public decimal? Period1 { get; set; }

    public decimal? Period2 { get; set; }

    public decimal? Period3 { get; set; }

    public decimal? Period4 { get; set; }

    public decimal? Period5 { get; set; }

    public decimal? Period6 { get; set; }

    public decimal? Period7 { get; set; }

    public decimal? Period8 { get; set; }

    public decimal? Period9 { get; set; }

    public decimal? Period10 { get; set; }

    public decimal? Period11 { get; set; }

    public decimal? Period12 { get; set; }

    public decimal? PeriodTot { get; set; }

    public decimal? PeriodAccu { get; set; }

    public string? CurrFormat { get; set; }

    public string? PercFormat { get; set; }

    public string? RecType { get; set; }

    public int? Color { get; set; }
}
