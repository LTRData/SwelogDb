using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwActualOperatorTimeSumupToReport
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public short OperationNumber { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public DateTime ReportDatetime { get; set; }

    public decimal SerialNumber { get; set; }

    public decimal? OperatorTime { get; set; }

    public decimal? OperatorSetupTime { get; set; }

    public string? PieceWorkTypeCode { get; set; }

    public decimal? PieceWorkRate { get; set; }

    public decimal? TimeWorkRate { get; set; }

    public int? UnitConversionFactor { get; set; }

    public string? WageType { get; set; }

    public decimal? Amount { get; set; }

    public decimal? SetupCost { get; set; }
}
