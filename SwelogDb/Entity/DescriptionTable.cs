using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DescriptionTable
{
    public string LanguageCode { get; set; } = null!;

    public string FunctionId { get; set; } = null!;

    public string DescriptionId { get; set; } = null!;

    public string? DescriptionText { get; set; }

    public string? AuditStamp { get; set; }
}
