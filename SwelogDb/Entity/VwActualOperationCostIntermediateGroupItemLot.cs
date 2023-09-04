using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwActualOperationCostIntermediateGroupItemLot
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? HiredOperationCost { get; set; }

    public decimal? OperatorCost { get; set; }

    public decimal? OperatorSetupCost { get; set; }

    public decimal? ResourceCost { get; set; }

    public decimal? ResourceSetupCost { get; set; }

    public decimal? SocialCost { get; set; }

    public decimal? MfgOverheadCost { get; set; }

    public decimal? CurrentTotalCost { get; set; }
}
