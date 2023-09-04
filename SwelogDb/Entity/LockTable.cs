using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class LockTable
{
    public string LockCode { get; set; } = null!;

    public string LockId { get; set; } = null!;

    public DateTime? LockTimestamp { get; set; }

    public string? LockWorkstationId { get; set; }

    public string? AdditionalInformation { get; set; }
}
