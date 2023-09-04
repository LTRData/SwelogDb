using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ActionDocument
{
    public string ActionListId { get; set; } = null!;

    public int ActionSerial { get; set; }

    public int DocumentSerial { get; set; }

    public string? DocumentTypeId { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ActionListDtl Action { get; set; } = null!;

    public virtual DocumentType? DocumentType { get; set; }
}
