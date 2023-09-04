using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MosMaterialShortageLog
{
    public int IdMosMaterialShortageLog { get; set; }

    public string? ParentItemNumber { get; set; }

    public int? ParentLotNumber { get; set; }

    public string? ComponentItemNumber { get; set; }

    public decimal? ReservedQty { get; set; }

    public decimal? ReservedQtyOther { get; set; }

    public decimal? NonExpiringBalance { get; set; }

    public decimal? StockBalance { get; set; }

    public string? ShortageFlag { get; set; }

    public DateTime? TransferDate { get; set; }
}
