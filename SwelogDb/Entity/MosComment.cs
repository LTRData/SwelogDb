using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MosComment
{
    public int IdMosComments { get; set; }

    public string? DemandId { get; set; }

    public string? ParentDemandId { get; set; }

    public string? ItemNumber { get; set; }

    public string? Comments { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? AuditStamp { get; set; }
}
