using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OperationListHdr
{
    public string OperationList { get; set; } = null!;

    public string? OperationListDesc { get; set; }

    public int? OperationListDescTxtid { get; set; }

    public string? OperationListDescFlag { get; set; }

    public DateTime? OperationListCreateDate { get; set; }

    public string? AuditStamp { get; set; }

    public string? RefType { get; set; }

    public string? Reference { get; set; }

    public string? ReferenceSub { get; set; }

    public virtual ICollection<ChangeItem> ChangeItems { get; } = new List<ChangeItem>();

    public virtual ICollection<Item> Items { get; } = new List<Item>();

    public virtual ICollection<OperationDtl> OperationDtlChildOperationListNavigations { get; } = new List<OperationDtl>();

    public virtual ICollection<OperationDtl> OperationDtlOperationListNavigations { get; } = new List<OperationDtl>();
}
