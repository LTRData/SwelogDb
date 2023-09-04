using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SharkOut
{
    public int RecNo { get; set; }

    public string? Status { get; set; }

    public string? Ordernumber { get; set; }

    public string? Itemnumber { get; set; }

    public decimal? Itempicked { get; set; }

    public short? Linenumber { get; set; }

    public string? Finaldelivery { get; set; }

    public string? NewPicklistCreated { get; set; }
}
