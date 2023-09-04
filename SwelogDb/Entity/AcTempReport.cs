using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AcTempReport
{
    public int SNo { get; set; }

    public string? SubHead { get; set; }

    public string? AccNumber { get; set; }

    public string? AcDesc { get; set; }

    public decimal? Column1 { get; set; }

    public decimal? Column2 { get; set; }

    public decimal? Column3 { get; set; }

    public decimal? Column4 { get; set; }

    public decimal? Column5 { get; set; }

    public decimal? Column6 { get; set; }

    public int? RoundOff { get; set; }

    public string? AccountingKey { get; set; }

    public string? Line { get; set; }
}
