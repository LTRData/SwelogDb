using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DocumentPrintPreference
{
    public int SerialNumber { get; set; }

    public string? IgnoreFilesEndingWith { get; set; }
}
