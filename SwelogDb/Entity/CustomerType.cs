using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerType
{
    public string CustomerTypeId { get; set; } = null!;

    public string? CustomerTypeDescription { get; set; }

    public string? AuditStamp { get; set; }
}
