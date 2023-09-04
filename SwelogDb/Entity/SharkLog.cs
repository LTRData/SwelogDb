using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SharkLog
{
    public int SerialNumber { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? ErrorType { get; set; }

    public string? ErrorCode { get; set; }

    public string? XmlFilePath { get; set; }

    public string? DeletedFlag { get; set; }

    public string? XmlContent { get; set; }

    public int? DuplicateRecNo { get; set; }
}
