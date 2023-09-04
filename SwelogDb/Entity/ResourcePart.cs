using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ResourcePart
{
    public int ResourcePartId { get; set; }

    public string? ResourceNo { get; set; }

    public string? ResourcePartNo { get; set; }

    public string? ResourcePartDescription { get; set; }

    public int? ResourcePartDescriptionTxtid { get; set; }

    public string? ResourcePartDescriptionFlag { get; set; }

    public string? AuditStamp { get; set; }
}
