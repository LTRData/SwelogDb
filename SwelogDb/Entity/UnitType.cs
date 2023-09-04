using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class UnitType
{
    public string TypeCode { get; set; } = null!;

    public string? TypeDescription { get; set; }

    public int? DimensionNo { get; set; }

    public string? AuditStamp { get; set; }

    public int? TypeDescriptionTxtid { get; set; }

    public virtual ICollection<UnitOfMeasure> UnitOfMeasures { get; } = new List<UnitOfMeasure>();
}
