using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class GradeAttributeScheme
{
    public string GradeAttributeScheme1 { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public decimal SupplyTimely { get; set; }

    public decimal SupplyQty { get; set; }

    public decimal SupplyQuality { get; set; }

    public decimal OwnGrade { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? N8dGrade { get; set; }

    public int IdGradeAttributeScheme { get; set; }

    public decimal? N8dGradeRepByCust { get; set; }
}
