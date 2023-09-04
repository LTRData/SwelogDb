using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TextType
{
    public string TextType1 { get; set; } = null!;

    public string? TextTypeDescription { get; set; }

    public int? TextTypeTxtid { get; set; }

    public string? TextTypeFlag { get; set; }

    public string? AuditStamp { get; set; }
}
