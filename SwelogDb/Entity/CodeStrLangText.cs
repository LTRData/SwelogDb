using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CodeStrLangText
{
    public short TransId { get; set; }

    public string LangCode { get; set; } = null!;

    public string? TransText { get; set; }
}
