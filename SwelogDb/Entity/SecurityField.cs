using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SecurityField
{
    public int SerialNumber { get; set; }

    public string? PrimaryObject { get; set; }

    public string? SecondaryObject { get; set; }

    public string? UserOrGroupName { get; set; }

    public byte? UserType { get; set; }

    public byte? TypeOfAccess { get; set; }
}
