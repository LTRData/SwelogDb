using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PocketProgram
{
    public int SerialNumber { get; set; }

    public string? ModuleId { get; set; }

    public string? ProgramId { get; set; }

    public string? ProgramName { get; set; }
}
