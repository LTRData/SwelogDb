using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemVersion
{
    public string ItemNumber { get; set; } = null!;

    public int Version { get; set; }

    public int VersionId { get; set; }

    public string? VersionDescr { get; set; }

    public string? OperationList { get; set; }

    public string? Structure { get; set; }

    public string? PriorVersion { get; set; }

    public string? Status { get; set; }

    public string? OrderTable { get; set; }

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public DateTime? ValidForProductionFrom { get; set; }

    public string? AuditStamp { get; set; }

    public string? ItemStatus1 { get; set; }

    public string? ItemStatus2 { get; set; }

    public string? VersionCode { get; set; }
}
