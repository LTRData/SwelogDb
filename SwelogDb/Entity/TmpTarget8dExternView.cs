using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpTarget8dExternView
{
    public int IdTmpTarget8dExternView { get; set; }

    public int? Spid { get; set; }

    public int? Yyyymm { get; set; }

    public string? Serie { get; set; }

    public string? CustomerId { get; set; }

    public string? Mr { get; set; }

    public decimal? Value { get; set; }
}
