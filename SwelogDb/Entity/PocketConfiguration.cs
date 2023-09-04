using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PocketConfiguration
{
    public int SerialNumber { get; set; }

    public string? ModuleId { get; set; }

    public string? ProgramId { get; set; }

    public DateTime? ValidUpto { get; set; }
}
