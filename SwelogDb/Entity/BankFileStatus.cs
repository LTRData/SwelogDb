using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BankFileStatus
{
    public int RecNo { get; set; }

    public string? BatchNo { get; set; }

    public DateTime? TransferDate { get; set; }

    public string? AuditStamp { get; set; }
}
