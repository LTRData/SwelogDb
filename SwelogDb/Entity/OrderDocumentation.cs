using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderDocumentation
{
    public string DocumentationId { get; set; } = null!;

    public string? DocumentationDesc { get; set; }

    public int? DocumentationDescTxtid { get; set; }

    public string? DocumentationDescFlag { get; set; }

    public string? OrderType { get; set; }

    public string? AuditStamp { get; set; }

    public string? UserIntExt { get; set; }

    public string? OrderTypeForCode { get; set; }

    public string? ShowLogo { get; set; }

    public string? ShowFooter { get; set; }

    public string LanguageCode { get; set; } = null!;
}
