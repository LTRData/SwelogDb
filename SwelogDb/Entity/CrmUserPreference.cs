using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmUserPreference
{
    public string UserId { get; set; } = null!;

    public string Preference { get; set; } = null!;

    public bool? Value { get; set; }
}
