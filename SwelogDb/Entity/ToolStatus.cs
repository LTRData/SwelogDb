using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ToolStatus
{
    public string ToolStatusCode { get; set; } = null!;

    public string? StatusDescription { get; set; }

    public int? StatusDescriptionTxtid { get; set; }

    public string? StatusDescriptionFlag { get; set; }

    public string? AuditStamp { get; set; }
}
