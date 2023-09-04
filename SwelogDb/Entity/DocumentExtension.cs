using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DocumentExtension
{
    public int SerialNumber { get; set; }

    public string? ExtensionDescription { get; set; }

    public string? ExtensionList { get; set; }
}
