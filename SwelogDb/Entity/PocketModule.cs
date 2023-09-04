using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PocketModule
{
    public int SerialNumber { get; set; }

    public string? ModuleId { get; set; }

    public string? ModuleName { get; set; }
}
