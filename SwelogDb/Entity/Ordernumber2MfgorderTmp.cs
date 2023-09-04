using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Ordernumber2MfgorderTmp
{
    public string OrderNumber2 { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public int LotNumber { get; set; }

    public string? ProductGroup { get; set; }

    public string? StockingUnit { get; set; }

    public decimal TotalIncCost { get; set; }

    public decimal DirectCost { get; set; }

    public decimal DirectWageCost { get; set; }

    public decimal SetupCost { get; set; }

    public decimal OverheadCost { get; set; }

    public decimal TotCost { get; set; }

    public decimal? DelQty { get; set; }

    public string? FinalDelivery { get; set; }

    public string UserId { get; set; } = null!;

    public string? MfgOrdernumber { get; set; }
}
