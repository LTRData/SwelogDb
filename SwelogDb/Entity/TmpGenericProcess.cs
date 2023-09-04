using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpGenericProcess
{
    public string TransactionId { get; set; } = null!;

    public int ProcessId { get; set; }

    public string? ItemNumber { get; set; }

    public string? SupplierId { get; set; }
}
