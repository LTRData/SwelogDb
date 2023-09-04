using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DocumentEventsPrint
{
    public int SerialNumber { get; set; }

    public int? EventSerialNumber { get; set; }

    public int? ObjectSerialNumber { get; set; }

    public int? ExtensionSerialNumber { get; set; }
}
