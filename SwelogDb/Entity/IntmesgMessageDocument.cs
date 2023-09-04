using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class IntmesgMessageDocument
{
    public int DocumentSerialNumber { get; set; }

    public int? MessageSerialNumber { get; set; }

    public string? DocumentPath { get; set; }

    public string? DocumentFilename { get; set; }
}
