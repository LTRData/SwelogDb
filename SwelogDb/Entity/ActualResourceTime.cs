using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ActualResourceTime
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public short OperationNumber { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public decimal SerialNumber { get; set; }

    public DateTime ReportDatetime { get; set; }

    public decimal? ResourceSetupTime { get; set; }

    public decimal? ResourceTime { get; set; }

    public decimal? QuantityProduced { get; set; }

    public short? NoOfSetup { get; set; }

    public string? ReportCompleteIndicator { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? PlanResourceTime { get; set; }

    public decimal? PlanResourceSetupTime { get; set; }

    public int? ReportedBy { get; set; }

    public string? ModuleId { get; set; }

    public string? ProductionGroupId { get; set; }

    public int? SequenceNo { get; set; }

    public DateTime? MpcUpdateDate { get; set; }

    public DateTime? StartDateTime { get; set; }

    public string? ActualResourceNumber { get; set; }

    public string? OperationType { get; set; }

    public int? TextId { get; set; }

    public decimal? QtyNotApproved { get; set; }
}
