using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MosSpecificItem
{
    public string? Identification { get; set; }

    public string? ItemNumber { get; set; }

    public DateTime? ProcessDate { get; set; }
}
