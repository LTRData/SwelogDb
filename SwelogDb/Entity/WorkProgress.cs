using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class WorkProgress
{
    public decimal WorkProgressSerial { get; set; }

    public string OperationSerial { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public int OperationNumber { get; set; }

    public decimal OrderedQuantity { get; set; }

    public string? PieceWorkTypeCode { get; set; }

    public decimal? PieceWorkRate { get; set; }

    public short? UnitConversionFactor { get; set; }

    public decimal? TimeWorkRate { get; set; }

    public decimal? SetupCost { get; set; }

    public string? WageType { get; set; }

    public string? ResourceNumber { get; set; }

    public short? EmployeeNumber { get; set; }

    public decimal? UsedSetUpTime { get; set; }

    public short? NoOfSetUp { get; set; }

    public decimal? UsedOperationSetUpTime { get; set; }

    public decimal? UsedResourceTime { get; set; }

    public decimal? UsedOperationTime { get; set; }

    public decimal? QuantityProduced { get; set; }

    public string? ReportCompleteIndicator { get; set; }

    public DateTime? ReportDate { get; set; }

    public decimal? Amount { get; set; }

    public string? AuditStamp { get; set; }

    public virtual PieceWorkType? PieceWorkTypeCodeNavigation { get; set; }

    public virtual ResourceTbl? ResourceNumberNavigation { get; set; }
}
