using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VmiLogFromPortalDetail
{
    public int SerialNumber { get; set; }

    public string? SupplierId { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public string? XmlFilename { get; set; }

    public string? ArchivedFilename { get; set; }

    public string? XmlData { get; set; }
}
