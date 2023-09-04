using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PiOfflineReport
{
    public int RowId { get; set; }

    public string ProductionGroupId { get; set; } = null!;

    public string ResourceNumber { get; set; } = null!;

    public DateTime ReportDateTime { get; set; }

    public string ActivityType { get; set; } = null!;

    public string? ActivityNo { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public short? OperationNumber { get; set; }

    public decimal QtyProduced { get; set; }

    public decimal QtyNotApproved { get; set; }

    public int ReportedBy { get; set; }

    public string FinalDelivery { get; set; } = null!;

    public DateTime? MpcUpdateDate { get; set; }

    public decimal ResourceTime { get; set; }

    public decimal ResourceSetupTime { get; set; }

    public short NoOfSetup { get; set; }

    public string? AuditStamp { get; set; }

    public int? ReportId { get; set; }

    public decimal? OperatorTime { get; set; }

    public decimal? OperatorSetupTime { get; set; }

    public bool? StockUpdatePending { get; set; }
}
