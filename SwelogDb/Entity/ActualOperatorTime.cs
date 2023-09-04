using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ActualOperatorTime
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public short OperationNumber { get; set; }

    public int EmployeeNumber { get; set; }

    public decimal SerialNumber { get; set; }

    public DateTime ReportDatetime { get; set; }

    public decimal? OperatorTime { get; set; }

    public decimal? OperatorSetupTime { get; set; }

    public decimal? QuantityProduced { get; set; }

    public short? NoOfSetup { get; set; }

    public string? PieceWorkTypeCode { get; set; }

    public decimal? PieceWorkRate { get; set; }

    public decimal? TimeWorkRate { get; set; }

    public int? UnitConversionFactor { get; set; }

    public string? ReportCompleteIndicator { get; set; }

    public string? WageType { get; set; }

    public decimal? SetupCost { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public decimal? Amount { get; set; }

    public decimal? PlanOperatorTime { get; set; }

    public decimal? PlanOperatorSetupTime { get; set; }

    public string? ModuleId { get; set; }

    public string? ProductionGroupId { get; set; }

    public int? SequenceNo { get; set; }

    public DateTime? MpcUpdateDate { get; set; }

    public string? OperationType { get; set; }

    public string? CustomerId { get; set; }

    public string? Comments { get; set; }

    public decimal? QtyNotApproved { get; set; }
}
