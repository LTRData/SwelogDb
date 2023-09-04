using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ActualOperationCostIntermediate
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public short OperationNumber { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public decimal SerialNumber { get; set; }

    public decimal? HiredOperationCost { get; set; }

    public decimal? OperatorCost { get; set; }

    public decimal? OperatorSetupCost { get; set; }

    public decimal? ResourceSetupCost { get; set; }

    public decimal? ResourceCost { get; set; }

    public decimal? SocialCost { get; set; }

    public decimal? MfgOverheadCost { get; set; }

    public decimal? CurrentTotalCost { get; set; }

    public decimal? OperatorTime { get; set; }

    public decimal? OperatorSetupTime { get; set; }

    public decimal? ResourceTime { get; set; }

    public decimal? ResourceSetupTime { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? QuantityProduced { get; set; }

    public DateTime ReportDatetime { get; set; }

    public float? DebitPrice { get; set; }

    public DateTime? EventDate { get; set; }

    public decimal? TransferJnlYearNo { get; set; }

    public string? TransferJnlSeries { get; set; }

    public decimal? TransferJnlVoucherNo { get; set; }

    public string? AccountJnlSeries { get; set; }

    public decimal? AccountJnlVoucherNo { get; set; }

    public string? OperationType { get; set; }

    public string? ErrorReportId { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public string? GoodsentryNo { get; set; }

    public string? ArrivalSeries { get; set; }

    public decimal? ArrivalNo { get; set; }
}
