using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmEventHistory
{
    public int SerialNumber { get; set; }

    public int? EventSerialNumber { get; set; }

    public short? StatusSerialNumber { get; set; }

    public string? UserId { get; set; }

    public DateTime? DateTime { get; set; }

    public string? Notes { get; set; }
}
