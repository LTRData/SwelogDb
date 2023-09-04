using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class UserPreference
{
    public int SerialNumber { get; set; }

    public string? Userid { get; set; }

    public string? Preference { get; set; }

    public string? Setting { get; set; }
}
