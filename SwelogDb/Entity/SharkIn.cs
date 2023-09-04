using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SharkIn
{
    public int RecNo { get; set; }

    public string? OrderNo { get; set; }

    public short? LineNo { get; set; }

    public string? ItemNo { get; set; }

    public decimal? Qty { get; set; }

    public string? TransCode { get; set; }

    public int? TranSerial { get; set; }

    public DateTime? TransactionDate { get; set; }
}
