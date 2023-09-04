using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgOperationListHdr
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public string? OperationListDesc { get; set; }

    public int? OperationListDescTxtid { get; set; }

    public string? OperationListDescFlag { get; set; }

    public DateTime? OperationListCreateDate { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<MfgOperationDtl> MfgOperationDtls { get; } = new List<MfgOperationDtl>();
}
