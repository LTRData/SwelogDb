using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TransactionType
{
    public string TransactionCode { get; set; } = null!;

    public short? TransactionQtySign { get; set; }

    public string? Description { get; set; }

    public string? AuditStamp { get; set; }

    public string LanguageCode { get; set; } = null!;
}
