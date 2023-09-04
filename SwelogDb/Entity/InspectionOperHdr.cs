using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class InspectionOperHdr
{
    public string OperationList { get; set; } = null!;

    public string? OperationListDesc { get; set; }

    public int? OperationListDescTxtid { get; set; }

    public string? OperationListDescFlag { get; set; }

    public string ItemType { get; set; } = null!;

    public DateTime? OperationListCreateDate { get; set; }

    public string? AuditStamp { get; set; }
}
