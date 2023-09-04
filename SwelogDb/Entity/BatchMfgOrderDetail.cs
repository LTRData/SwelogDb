using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BatchMfgOrderDetail
{
    public int SerialNumber { get; set; }

    public int LineNumber { get; set; }

    public string? ComponentItemNumber { get; set; }

    public string? ComponentRevisionNumber { get; set; }

    public int? ComponentLotNumber { get; set; }

    public decimal? OrderQuantity { get; set; }

    public string? StockingUnit { get; set; }

    public decimal? ReportedQuantity { get; set; }

    public string? MfgOrderNumber { get; set; }

    public virtual BatchMfgOrderHeader SerialNumberNavigation { get; set; } = null!;
}
