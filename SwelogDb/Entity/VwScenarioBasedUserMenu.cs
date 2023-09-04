using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwScenarioBasedUserMenu
{
    public string? UserOrGroup { get; set; }

    public string? MenuText { get; set; }

    public string? SwelogMenuId { get; set; }

    public int SerialNumber { get; set; }

    public int? ParentSerialNumber { get; set; }

    public int? SortOrder { get; set; }

    public int? RoleSerialNumber { get; set; }
}
