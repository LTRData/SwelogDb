using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmActivityDocument
{
    public int ActivitySerialNumber { get; set; }

    public int DocumentSerialNumber { get; set; }

    public string? DocumentPath { get; set; }

    public string? DocumentFilename { get; set; }
}
