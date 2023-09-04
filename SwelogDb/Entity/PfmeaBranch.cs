using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PfmeaBranch
{
    public int IdPfmeaBranch { get; set; }

    public int? PfmeaId { get; set; }

    public int? VersionNumber { get; set; }

    public int? ParentId { get; set; }

    public string? RecType { get; set; }

    public string? BranchName { get; set; }

    public string? WorkElement { get; set; }

    public string? PreventionControl { get; set; }

    public short? SortOrder { get; set; }

    public short? Severity { get; set; }

    public short? Occurance { get; set; }

    public short? Detection { get; set; }

    public string? AuditStamp { get; set; }

    public bool? DefaultValue { get; set; }

    public int? LinkFuncpiId { get; set; }

    public bool? ManufactureFlag { get; set; }

    public bool? MoveFlag { get; set; }

    public bool? WarehouseFlag { get; set; }

    public bool? InspectionFlag { get; set; }
}
