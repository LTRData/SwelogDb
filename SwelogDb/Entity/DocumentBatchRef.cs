using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DocumentBatchRef
{
    public string? MfgOrderNumber { get; set; }

    public int DocumentBatch { get; set; }

    public int DocumentLotNumber { get; set; }

    public string? AuditStamp { get; set; }

    public int? SerialInBatch { get; set; }

    public int? IndexInOrder { get; set; }
}
