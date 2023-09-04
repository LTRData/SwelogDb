using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpDefinedToolReactivate
{
    public int ProcessId { get; set; }

    public string ToolNumber { get; set; } = null!;

    public string? ToolType { get; set; }

    public string ToolReactivateType { get; set; } = null!;

    public string? VersionDescr { get; set; }

    public string? ReactivationDesc { get; set; }

    public string? OperationList { get; set; }

    public string? Structure { get; set; }

    public string? Status { get; set; }

    public DateTime? ValidForProductionFrom { get; set; }

    public string? ItemStatus1 { get; set; }

    public string? ItemStatus2 { get; set; }

    public DateTime? OperationValidForProductionFrom { get; set; }

    public DateTime? StructureValidForProductionFrom { get; set; }

    public string? OperationRefType { get; set; }

    public string? StructureRefType { get; set; }

    public string? OperationRefDescription { get; set; }

    public string? StructureRefDescription { get; set; }
}
