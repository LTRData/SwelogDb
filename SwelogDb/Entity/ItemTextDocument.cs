using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemTextDocument
{
    public string ItemNumber { get; set; } = null!;

    public string GeneralTextId { get; set; } = null!;

    public string GeneralTextIndicator { get; set; } = null!;

    public string LanguageCode { get; set; } = null!;

    public string DocumentId { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
