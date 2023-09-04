using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PalletMaterialDtl
{
    public int IdPalletMaterialDtl { get; set; }

    public string PalletNo { get; set; } = null!;

    public decimal? QuantityProduced { get; set; }

    public string MaterialItemNumber { get; set; } = null!;

    public string MaterialPalletNo { get; set; } = null!;

    public DateTime IssueDate { get; set; }

    public string? MaterialControlId { get; set; }

    public decimal? QuantityIssued { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }

    public DateTime? ReportDateTime { get; set; }

    public int? ReportedBy { get; set; }
}
