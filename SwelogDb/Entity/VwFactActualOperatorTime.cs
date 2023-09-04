using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwFactActualOperatorTime
{
    public int? MfgOrderSerialKey { get; set; }

    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public short OperationNumber { get; set; }

    public string? ItemDescription { get; set; }

    public string? PieceWorkTypeCode { get; set; }

    public string? RequiredSkillLevel { get; set; }

    public string? OperationStatus { get; set; }

    public DateTime ReportDatetime { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public int EmployeeNumber { get; set; }

    public string? ReportCompleteIndicator { get; set; }

    public int? UnitConversionFactor { get; set; }

    public decimal? ProducedQuantity { get; set; }

    public decimal? NotApprovedQuantity { get; set; }

    public decimal? PlannedTime { get; set; }

    public decimal? OperatorTime { get; set; }

    public decimal? OperatorSetupTime { get; set; }
}
