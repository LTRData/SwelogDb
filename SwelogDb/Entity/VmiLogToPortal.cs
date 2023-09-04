using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VmiLogToPortal
{
    public int SerialNumber { get; set; }

    public DateTime? ExecutionTimestamp { get; set; }

    public string? SupplierId { get; set; }

    public string? Status { get; set; }

    public string? XmlFilename { get; set; }

    public string? ArchivedFilename { get; set; }
}
