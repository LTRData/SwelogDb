using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class QualificationLevel
{
    public string QualificationLevel1 { get; set; } = null!;

    public string? QualificationDesc { get; set; }

    public int? QualificationDescTxtid { get; set; }

    public string? QualificationDescFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ChangeOperationDtl> ChangeOperationDtls { get; } = new List<ChangeOperationDtl>();

    public virtual ICollection<InspectionOperDtl> InspectionOperDtls { get; } = new List<InspectionOperDtl>();

    public virtual ICollection<OperationDtl> OperationDtls { get; } = new List<OperationDtl>();
}
