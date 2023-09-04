using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OperatorDirectTime
{
    public string ItemNo { get; set; } = null!;

    public int LotNo { get; set; }

    public int OperationNo { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public DateTime ReportDateTime { get; set; }

    public int EmployeeNumber { get; set; }

    public decimal? OperatorTime { get; set; }

    public decimal? OperatorSetupTime { get; set; }

    public int? NoOfSetup { get; set; }

    public decimal? ProducedQty { get; set; }

    public string? PieceWorkTypeCode { get; set; }

    public decimal? PieceWorkRate { get; set; }

    public decimal? TimeWorkRate { get; set; }

    public int? UnitConversionFactor { get; set; }

    public string? FinishFlag { get; set; }

    public string? WageType { get; set; }

    public decimal? SetupCost { get; set; }

    public decimal? Amount { get; set; }

    public int? ActivityReportedBy { get; set; }

    public string? UpdateOption { get; set; }

    public string? AuditStamp { get; set; }

    public DateTime? StartDateTime { get; set; }

    public int SequenceNo { get; set; }

    public string? ProductionGroupId { get; set; }

    public DateTime? MpcStartDate { get; set; }

    public DateTime? MpcEndDate { get; set; }
}
