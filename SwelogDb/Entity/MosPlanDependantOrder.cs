using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MosPlanDependantOrder
{
    public string ParentItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public string ChildItemNumber { get; set; } = null!;

    public decimal? DerivedOrderQty { get; set; }

    public DateTime? OrderStartDate { get; set; }

    public DateTime? OrderFinishDate { get; set; }

    public int? OldLotNumber { get; set; }

    public string? AuditStamp { get; set; }

    public int OperationNumber { get; set; }

    public string? OrderLine { get; set; }

    public string? OrderNumber { get; set; }
}
