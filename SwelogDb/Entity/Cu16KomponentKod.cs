using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu16KomponentKod
{
    public int SerialNumber { get; set; }

    public string? KomponentKod { get; set; }

    public short? OperationNumber { get; set; }

    public string? Comments { get; set; }
}
