using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwFactMfgOperationDtl
{
    public string MfgOrderNumber { get; set; } = null!;

    public int? MfgOrderSerialKey { get; set; }

    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public short OperationNumber { get; set; }

    public string? OperationDesc { get; set; }

    public string? ItemDescription { get; set; }

    public string? PieceWorkTypeCode { get; set; }

    public string? RequiredSkillLevel { get; set; }

    public string? OperationStatus { get; set; }

    public string? MfgOrderStatus { get; set; }

    public DateTime? MfgOrderStartDate { get; set; }

    public DateTime? MfgOrderFinishDate { get; set; }

    public int? UnitConversionFactor { get; set; }

    public decimal? OrderedQuantity { get; set; }

    public decimal? ProducedQuantity { get; set; }

    public decimal? NotApprovedQuantity { get; set; }

    public decimal? DeliveredQuantity { get; set; }

    public decimal? ActualResourceTime { get; set; }

    public decimal? ResourceInterruptTime { get; set; }

    public decimal? PlannedTimeForQroducedQuantity { get; set; }

    public DateTime? ActualFinishDate { get; set; }

    public string? ResourceNumber { get; set; }

    public decimal? PlannedTime { get; set; }
}
