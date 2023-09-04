using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ChangeOrderDtl
{
    public string ChangeOrderId { get; set; } = null!;

    public int ChangeOrderSerial { get; set; }

    public short? ChangeOrderLineType { get; set; }

    public string? ChangeOrderItemNo { get; set; }

    public string? OldItemNo { get; set; }

    public string? DrawingNo { get; set; }

    public string? OldDrawingNo { get; set; }

    public string? RevisionNo { get; set; }

    public string? OldRevisionNo { get; set; }

    public string? ProductStructure { get; set; }

    public string? OldProductStructure { get; set; }

    public string? OperationListId { get; set; }

    public string? OldOperationList { get; set; }

    public DateTime? EffectFromDate { get; set; }

    public string? EffectFromProject { get; set; }

    public decimal? EffectFromOnHandBalance { get; set; }

    public int? EffectFromSerialNo { get; set; }

    public string? DetailDistList { get; set; }

    public string? ActionForDtl { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ActionListHdr? ActionForDtlNavigation { get; set; }

    public virtual DistributionListHdr? DetailDistListNavigation { get; set; }

    public virtual ICollection<EcoActionList> EcoActionLists { get; } = new List<EcoActionList>();
}
