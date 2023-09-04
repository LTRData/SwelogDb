using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SwelogOperation
{
    public string OperationId { get; set; } = null!;

    public string LanguageCode { get; set; } = null!;

    public string? OperationDescription { get; set; }

    public string? AuthorityLevelComment { get; set; }
}
