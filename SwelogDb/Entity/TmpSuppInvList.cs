using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpSuppInvList
{
    public int RecId { get; set; }

    public int? ProcessId { get; set; }

    public string? CompanyNo { get; set; }

    public string? Preattest1 { get; set; }

    public string? Preattest2 { get; set; }

    public string? Finalattest { get; set; }

    public string? ArrivalSeriesNo { get; set; }
}
