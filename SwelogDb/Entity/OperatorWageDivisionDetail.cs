using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OperatorWageDivisionDetail
{
    public string HeaderActivityNo { get; set; } = null!;

    public string ActivityNo { get; set; } = null!;

    public DateTime ReportDateTime { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public int EmployeeNumber { get; set; }

    public decimal? Finished { get; set; }

    public decimal? ProducedQty { get; set; }

    public decimal? ProdAmount { get; set; }

    public string? PieceWorkTypeCode { get; set; }

    public decimal? PieceWorkRate { get; set; }

    public short? ConvFactor { get; set; }

    public string? WageType { get; set; }

    public DateTime? MpcStartDate { get; set; }

    public DateTime? MpcEndDate { get; set; }

    public string? AuditStamp { get; set; }
}
