using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ModuleSetup
{
    public string ModuleName { get; set; } = null!;

    public short SerialNo { get; set; }

    public string? LanguageCode { get; set; }

    public string? DisplayText { get; set; }

    public string? LongText { get; set; }

    public string? ActionObject { get; set; }
}
