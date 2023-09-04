using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PocketSecurity
{
    public int SerialNumber { get; set; }

    public string? UserOrGroupName { get; set; }

    public byte? UserType { get; set; }

    public string? ModuleId { get; set; }

    public string? ProgramId { get; set; }
}
