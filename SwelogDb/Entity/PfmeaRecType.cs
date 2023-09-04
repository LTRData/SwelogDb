using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PfmeaRecType
{
    public string RecType { get; set; } = null!;

    public string LanguageCode { get; set; } = null!;

    public string? RecTypeDescription { get; set; }

    public short? RecLevel { get; set; }
}
