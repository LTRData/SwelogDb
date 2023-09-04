using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgOperationUserBunch
{
    public long Row { get; set; }

    public int? MfgOrderSerialKey { get; set; }

    public int? EmploymentNumber { get; set; }

    public string? BunchId { get; set; }

    public DateTime? StartDateTime { get; set; }
}
