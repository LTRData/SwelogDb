using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class GeneralTextDetail
{
    public string TextType { get; set; } = null!;

    public string TextKey { get; set; } = null!;

    public string OrderTextId { get; set; } = null!;

    public string DocumentId { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public string LanguageCode { get; set; } = null!;

    public virtual GeneralTextHeader GeneralTextHeader { get; set; } = null!;
}
