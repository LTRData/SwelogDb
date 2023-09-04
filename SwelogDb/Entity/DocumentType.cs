using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DocumentType
{
    public string DocumentTypeId { get; set; } = null!;

    public string? Description { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ActionDocument> ActionDocuments { get; } = new List<ActionDocument>();

    public virtual ICollection<EcoDocument> EcoDocuments { get; } = new List<EcoDocument>();

    public virtual ICollection<EcoDocumentsForHdr> EcoDocumentsForHdrs { get; } = new List<EcoDocumentsForHdr>();
}
