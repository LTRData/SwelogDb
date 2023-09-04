using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DocumentPath
{
    public int SerialNumber { get; set; }

    public string? PrimaryObjectName { get; set; }

    public string? Path { get; set; }

    public int? ExtensionSerialNumber { get; set; }
}
