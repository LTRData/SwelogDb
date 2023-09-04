using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MenuUserRole
{
    public int SerialNumber { get; set; }

    public string? UserOrGroup { get; set; }

    public int? UserType { get; set; }

    public int? RoleSerialNumber { get; set; }

    public bool? PrimaryRole { get; set; }

    public virtual SecurityUser? UserOrGroupNavigation { get; set; }
}
