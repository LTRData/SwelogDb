using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MessageOperation
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public short OperationNumber { get; set; }

    public int? MessageId { get; set; }

    public string? MessageStatus { get; set; }

    public string? MessageRead { get; set; }

    public string? DoNotShowAgain { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreationTimestamp { get; set; }

    public string? ReadHistory { get; set; }

    public string? ChangeHistory { get; set; }

    public string? AuditStamp { get; set; }
}
