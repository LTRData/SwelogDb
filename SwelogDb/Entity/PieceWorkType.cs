using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PieceWorkType
{
    public string PieceWorkTypeCode { get; set; } = null!;

    public string? PieceWorkDescription { get; set; }

    public int? PieceWorkDescriptionTxtid { get; set; }

    public string? PieceWorkDescriptionFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<WorkProgress> WorkProgresses { get; } = new List<WorkProgress>();
}
