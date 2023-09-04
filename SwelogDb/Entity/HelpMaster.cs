using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class HelpMaster
{
    public string LanguageCode { get; set; } = null!;

    public string PrimaryObject { get; set; } = null!;

    public string SecondaryObject { get; set; } = null!;

    public string? HelpText { get; set; }
}
