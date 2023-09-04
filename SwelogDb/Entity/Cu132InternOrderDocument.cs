using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu132InternOrderDocument
{
    public int SerialNumber { get; set; }

    public int? InternOrderSerialNumber { get; set; }

    public int? DocumentSerialNumber { get; set; }
}
