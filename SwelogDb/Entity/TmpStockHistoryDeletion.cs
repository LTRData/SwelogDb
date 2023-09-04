using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpStockHistoryDeletion
{
    public int? ProcessId { get; set; }

    public string? ItemNo { get; set; }

    public string? ItemDescription { get; set; }

    public int? NoOfTransactions { get; set; }

    public byte? OkToDelete { get; set; }

    public DateTime? ReferenceDate { get; set; }
}
