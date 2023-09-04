using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ChangeOperationListHdr
{
    public string OperationList { get; set; } = null!;

    public string? OperationListDesc { get; set; }

    public int? OperationListDescTxtid { get; set; }

    public string? OperationListDescFlag { get; set; }

    public DateTime? OperationListCreateDate { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ChangeOperationDtl> ChangeOperationDtlChildOperationListNavigations { get; } = new List<ChangeOperationDtl>();

    public virtual ICollection<ChangeOperationDtl> ChangeOperationDtlOperationListNavigations { get; } = new List<ChangeOperationDtl>();
}
