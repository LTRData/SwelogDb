using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TextFilePath
{
    public string FileCode { get; set; } = null!;

    public string? FileDescription { get; set; }

    public string? FilePath { get; set; }

    public string? AuditStamp { get; set; }
}
