using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VmiHeader
{
    public string? OrderNumber { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? SupplierId { get; set; }

    public string? ReferenceNumber { get; set; }
}
