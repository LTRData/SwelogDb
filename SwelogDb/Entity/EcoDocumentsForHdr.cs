using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EcoDocumentsForHdr
{
    public string ChangeOrderId { get; set; } = null!;

    public string ActionListId { get; set; } = null!;

    public int ActionSerial { get; set; }

    public int DocumentSerial { get; set; }

    public string? DocumentTypeId { get; set; }

    public string? PathOfDocCreated { get; set; }

    public DateTime? DocumentDate { get; set; }

    public string? DistributionListId { get; set; }

    public string? AuditStamp { get; set; }

    public virtual DistributionListHdr? DistributionList { get; set; }

    public virtual DocumentType? DocumentType { get; set; }

    public virtual EcoActionListForHdr EcoActionListForHdr { get; set; } = null!;
}
