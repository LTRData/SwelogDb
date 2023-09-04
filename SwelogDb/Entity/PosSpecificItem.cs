using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PosSpecificItem
{
    public string? Identification { get; set; }

    public string? ItemNumber { get; set; }

    public DateTime? ProcessDate { get; set; }
}
