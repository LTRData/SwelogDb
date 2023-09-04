using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class UtleveransunderlagPreference
{
    public int SerialNumber { get; set; }

    public string? Userid { get; set; }

    public string? CustomerId { get; set; }
}
