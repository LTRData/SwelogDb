using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class RejectionCost
{
    public string ResourceNumber { get; set; } = null!;

    public DateTime ReportDatetime { get; set; }

    public int ActivityNo { get; set; }

    public string RejectionCode { get; set; } = null!;

    public decimal? QtyRejected { get; set; }

    public decimal? RawMaterialCostComp { get; set; }

    public decimal? RawMaterialOverheadComp { get; set; }

    public decimal? PurchaseItemCostComp { get; set; }

    public decimal? PurchaseFxdOrdCostComp { get; set; }

    public decimal? PurchaseOverhdCostComp { get; set; }

    public decimal? OperatorCostComp { get; set; }

    public decimal? OperatorSetupCostComp { get; set; }

    public decimal? MfgOverheadCostComp { get; set; }

    public decimal? CurrentTotalCostComp { get; set; }

    public decimal? HiredOperationCostOwn { get; set; }

    public decimal? OperatorCostOwn { get; set; }

    public decimal? OperatorSetupCostOwn { get; set; }

    public decimal? ResourceSetupCostOwn { get; set; }

    public decimal? ResourceCostOwn { get; set; }

    public decimal? SocialCostOwn { get; set; }

    public decimal? MfgOverheadCostOwn { get; set; }

    public decimal? CurrentTotalCostOwn { get; set; }

    public string? AuditStamp { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public decimal? DirectCostComp { get; set; }

    public int? OperationNumber { get; set; }

    public DateTime? EventDate { get; set; }

    public decimal? TransferJnlYearNo { get; set; }

    public string? TransferJnlSeries { get; set; }

    public decimal? TransferJnlVoucherNo { get; set; }

    public string? AccountJnlSeries { get; set; }

    public decimal? AccountJnlVoucherNo { get; set; }
}
