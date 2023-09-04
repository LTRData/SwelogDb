using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ExceptionMessage
{
    public string ExceptionCode { get; set; } = null!;

    public string? ExceptionDescription { get; set; }

    public int? ExceptionDescriptionTxtid { get; set; }

    public string? ExceptionDescriptionFlag { get; set; }

    public string? AuditStamp { get; set; }
}
