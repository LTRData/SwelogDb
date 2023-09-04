using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DistributionListHdr
{
    public string DistributionListId { get; set; } = null!;

    public string? ListDescription { get; set; }

    public DateTime? ListEffectiveFrom { get; set; }

    public DateTime? ListEffectiveUntil { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ChangeOrderDtl> ChangeOrderDtls { get; } = new List<ChangeOrderDtl>();

    public virtual ICollection<ChangeOrderHdr> ChangeOrderHdrs { get; } = new List<ChangeOrderHdr>();

    public virtual ICollection<DistributionListDtl> DistributionListDtls { get; } = new List<DistributionListDtl>();

    public virtual ICollection<EcoActionListForHdr> EcoActionListForHdrs { get; } = new List<EcoActionListForHdr>();

    public virtual ICollection<EcoActionList> EcoActionLists { get; } = new List<EcoActionList>();

    public virtual ICollection<EcoDocument> EcoDocuments { get; } = new List<EcoDocument>();

    public virtual ICollection<EcoDocumentsForHdr> EcoDocumentsForHdrs { get; } = new List<EcoDocumentsForHdr>();
}
