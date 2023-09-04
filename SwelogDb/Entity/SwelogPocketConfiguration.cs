using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SwelogPocketConfiguration
{
    public int SerialNumber { get; set; }

    public string? ShortName { get; set; }

    public bool? Active { get; set; }

    public string? Window { get; set; }

    public string? Picture { get; set; }

    public byte? SortOrder { get; set; }
}
