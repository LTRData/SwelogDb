using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SkillLevel
{
    public string SkillLevel1 { get; set; } = null!;

    public string? SkillDescription { get; set; }

    public int? SkillDescriptionTxtid { get; set; }

    public string? SkillDescriptionFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ChangeOperationDtl> ChangeOperationDtls { get; } = new List<ChangeOperationDtl>();

    public virtual ICollection<InspectionOperDtl> InspectionOperDtls { get; } = new List<InspectionOperDtl>();

    public virtual ICollection<OperationDtl> OperationDtls { get; } = new List<OperationDtl>();
}
