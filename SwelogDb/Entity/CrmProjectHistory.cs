using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmProjectHistory
{
    public int SerialNumber { get; set; }

    public int? ProjectSerialNumber { get; set; }

    public short? StatusSerialNumber { get; set; }

    public string? UserId { get; set; }

    public DateTime? DateTime { get; set; }
}
