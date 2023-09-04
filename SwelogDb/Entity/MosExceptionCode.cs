using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MosExceptionCode
{
    public string ExceptionCode { get; set; } = null!;

    public string LanguageCode { get; set; } = null!;

    public string? Description { get; set; }

    public string? AuditStamp { get; set; }

    public int? UrgencyLevel { get; set; }
}
