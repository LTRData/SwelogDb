using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class UserDefinedDocument
{
    public int Id { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string ModuleId { get; set; } = null!;

    public string SearchString { get; set; } = null!;

    public string? DocumentDescription { get; set; }

    public string? AuditStamp { get; set; }
}
