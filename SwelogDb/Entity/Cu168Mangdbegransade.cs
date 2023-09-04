using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu168Mangdbegransade
{
    public int SerialNumber { get; set; }

    public string? MangdbegransadeKod { get; set; }

    public string? MangdbegransadeBeskrivning { get; set; }

    public int? GroupCode { get; set; }
}
